using System;
using System.Collections.Generic;
using System.Threading;
using size_t = System.UInt64;

namespace SylvanSharp
{
	public static class Lace
	{
		const string DLLNAME = "sylvan_native";
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_init")]
		static extern void _Init(int nthreads, size_t dqsize);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_init_worker")]
		static extern void lace_init_worker(int worker, size_t dqsize);

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_run_default_worker")]
		static extern void lace_worker_steal_loop();
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_default_stacksize")]
		static extern size_t lace_default_stacksize();
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_workers")]
		static extern size_t lace_workers();
		
		static void LaceThreadEntry(object _args)
		{
			var args = _args as Tuple<int, size_t, Action<Exception>>;
			lace_init_worker(args.Item1, args.Item2);
			try {
				lace_worker_steal_loop();
			} catch(Exception ex) {
				if(args.Item3!=null) {
					args.Item3.Invoke(ex);
				} else {
					throw ex;
				}
			}
		}
		
		private static List<Thread> _threads = new List<Thread>();
		public static void Init(int nthreads=0, size_t dqsize=0, int stacksize=0, Action<Exception> ex_handler=null)
		{
			_Init(nthreads, dqsize);
			if(stacksize == 0) 
			{ 
				stacksize = (int)lace_default_stacksize();
			}
			if(nthreads == 0)
			{
				nthreads = (int)lace_workers();
			}
			// start workers
			for (int i = 1; i < nthreads; i++)
	        {
	            Thread thread = new Thread(new ParameterizedThreadStart(LaceThreadEntry), stacksize);
	            thread.IsBackground = true;
	            thread.Name = string.Format("LaceWorker{0}",i);
	            _threads.Add(thread);
	            thread.Start(Tuple.Create(i, dqsize, ex_handler));
	        }
	        // make calling thread a lace thread
			lace_init_worker(0, dqsize);
		}

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_exit")]
		public static extern void Exit();

		// [global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_spawn")]
		// public static extern void lace_spawn(lace_spawn_function f);

		// [global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sync")]
		// public static extern void lace_sync();
		
		public delegate void lace_protected_region();
		public delegate void lace_spawn_function(int i);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_parallel_for_0")]
		public static extern void ParallelFor(lace_spawn_function f, int iter);
		
		public static Int64 CreateMutex() {
			return 1;
		}
		
		public static void FreeMutex(ref Int64 m) {
			m = -1;
			return;
		}
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_lock_region")]
		public static extern void LockRegion(ref Int64 m, lace_protected_region region);
	}
}
