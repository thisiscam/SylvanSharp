using System;

using size_t=System.UInt64;

namespace SylvanSharp
{
	public static class Lace
	{
		const string DLLNAME = "sylvan_native";
		

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sharp_init_lace")]
		public static extern void Init(int threads, size_t stacksize);

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
