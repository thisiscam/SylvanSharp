using System;
using System.Runtime.InteropServices;

using BDDVAR = System.UInt32;
using BDD = System.Int64;
using size_t=System.UInt64;

namespace SylvanSharp
{
	public static class SylvanSharpPInvoke
	{
		const string DLLNAME = "sylvan_native";
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_set_granularity")]
		public static extern void set_granularity(int granularity);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_get_granularity")]
		public static extern int get_granularity();
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_make_true")]
		public static extern BDD make_true();
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_make_false")]
		public static extern BDD make_false();
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_ithvar")]
		public static extern BDD ithvar(BDDVAR var);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_not")]
		public static extern BDD not(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_and")]
		public static extern BDD and(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_or")]
		public static extern BDD or(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_xor")]
		public static extern BDD xor(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_ite")]
		public static extern BDD ite(BDD a, BDD b, BDD c);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_equals")]
		public static extern BDD equals(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_not_equals")]
		public static extern BDD not_equals(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_exists")]
		public static extern BDD exists(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_constrain")]
		public static extern BDD constrain(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_restrict")]
		public static extern BDD restrict(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_implies")]
		public static extern BDD implies(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_support")]
		public static extern BDD support(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_var_bdd")]
		public static extern BDD var_bdd(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_high")]
		public static extern BDD high(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_low")]
		public static extern BDD low(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_var")]
		public static extern BDDVAR var(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_addref")]
		public static extern void addref(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_delref")]
		public static extern void delref(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_protect")]
		public static extern void protect(ref BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_unprotect")]
		public static extern void unprotect(ref BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_satcount")]
		public static extern void satcount(BDD bdd, BDD variables);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_nodecount")]
		public static extern size_t nodecount(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_init_lace")]
		public static extern void init_lace(int threads, size_t stacksize);

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_exit_lace")]
		public static extern void exit_lace();
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_init_package")]
		public static extern void init_package(size_t tablesize, size_t max_tablesize, size_t cachesize, size_t max_cachesize);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_print")]
		public static extern void print(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_fprint")]
		public static extern void fprint(string filename, BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_print_dot")]
		public static extern void print_dot(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_fprint_dot")]
		public static extern void fprint_dot(string filename, BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_disable_gc")]
		public static extern void disable_gc();
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_enable_gc")]
		public static extern void enable_gc();

		public delegate void lace_spawn_function0();
		public delegate void lace_spawn_function<T>(T arg0);
		public delegate void lace_spawn_function2<T0, T1>(T0 arg0, T1 arg1);

		// [global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_spawn")]
		// public static extern void lace_spawn(lace_spawn_function f);

		// [global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_sync")]
		// public static extern void lace_sync();

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_parallel_for_0")]
		public static extern void lace_parallel_for(Intptr f, int iter);

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="lace_parallel_for_1")]
		private static extern void lace_parallel_for(Intptr f, int iter, Intptr data);

		public static void lace_parallel_for<T>(lace_spawn_function<T> f, T[] data)
		{
			lace_parallel_for(f, data.Length, data);
		}
	}
}
