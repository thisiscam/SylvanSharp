using System;

using BDDVAR = System.Int32;
using BDD = System.Int64;

namespace SylvanSharp
{
	public static partial class SylvanSharp
	{
		public static void init(
								int lace_threads, UInt64 lace_stack, 
								int tablesize_lg2, int max_tablesize_lg2, 
								int cachesize_lg2, int max_cachesize_lg2,
								int granularity=0
							)
		{
			UInt64 table_size = 1UL << tablesize_lg2;
			UInt64 max_tablesize = 1UL << max_tablesize_lg2;
			UInt64 cachesize = 1UL << cachesize_lg2;
			UInt64 max_cachesize = 1UL << max_cachesize_lg2;
			SylvanSharp.init_lace(lace_threads, lace_stack);
			SylvanSharp.init_package(table_size, max_tablesize, cachesize, max_cachesize);
			SylvanSharp.set_granularity(granularity);
		}
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_not_addref")]
		public static extern BDD sylvan_sharp_not_addref(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_and_addref")]
		public static extern BDD sylvan_sharp_and_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_or_addref")]
		public static extern BDD sylvan_sharp_or_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_xor_addref")]
		public static extern BDD sylvan_sharp_xor_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_ite_addref")]
		public static extern BDD sylvan_sharp_ite_addref(BDD a, BDD b, BDD c);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_diff_addref")]
		public static extern BDD sylvan_sharp_diff_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_less_addref")]
		public static extern BDD sylvan_sharp_less_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_exists_addref")]
		public static extern BDD sylvan_sharp_exists_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_constrain_addref")]
		public static extern BDD sylvan_sharp_constrain_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_restrict_addref")]
		public static extern BDD sylvan_sharp_restrict_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_imp_addref")]
		public static extern BDD sylvan_sharp_imp_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_invimp_addref")]
		public static extern BDD sylvan_sharp_invimp_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_biimp_addref")]
		public static extern BDD sylvan_sharp_biimp_addref(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_support_addref")]
		public static extern BDD sylvan_sharp_support_addref(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_var_bdd_addref")]
		public static extern BDD sylvan_sharp_var_bdd_addref(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_high_addref")]
		public static extern BDD sylvan_sharp_high_addref(BDD bdd);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME,EntryPoint="sylvan_sharp_low_addref")]
		public static extern BDD sylvan_sharp_low_addref(BDD bdd);

	}
}
