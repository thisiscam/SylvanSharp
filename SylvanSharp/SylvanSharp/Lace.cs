using System;
using System.Collections.Generic;
using System.Threading;
using size_t = System.UInt64;

namespace SylvanSharp
{
	public static class Lace
	{
		const string DLLNAME = "sylvan_native";
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_init_lace")]
		static extern void _Init(int nthreads, size_t dqsize);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_init_worker")]
		static extern void lace_init_worker(int worker, size_t dqsize);

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_steal_loop")]
		static extern void lace_worker_steal_loop();
		
		static void LaceThreadEntry(int worker, size_t dqsize)
		{
			lace_sharp_init_worker(worker, dqsize);
			lace_worker_steal_loop();
		}
		
		private static List<Thread> _threads = new List<Thread>();
		public static void Init(int nthreads, size_t dqsize)
		{
			lace_sharp_init_worker(threads, dqsize);
			// make calling thread a lace thread
			_StartLaceThread(0, dqsize);
			// start workers
			for (int i = 1; i < threads; i++)
	        {
	            Thread thread = new Thread(() => LaceThreadEntry(i, dqsize));
	            thread.IsBackground = true;
	            thread.Name = string.Format("LaceWorkerThread{0}",i);
	            _threads.Add(thread);
	            thread.Start();
	        }
		}

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_exit_lace")]
		public static extern void Exit();

		// [global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_spawn")]
		// public static extern void lace_spawn(lace_spawn_function f);

		// [global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sync")]
		// public static extern void lace_sync();

		public delegate void lace_spawn_function(int i);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_parallel_for_0")]
		public static extern void ParallelFor(lace_spawn_function f, int iter);
	}
}
