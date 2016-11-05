using System;

using BDDVAR = System.UInt32;
using BDD = System.Int64;

namespace SylvanSharp
{
	public static class Sylvan
	{
		
		public static readonly bdd bddtrue = new bdd(SylvanSharpPInvoke.make_true());
		public static readonly bdd bddfalse = new bdd(SylvanSharpPInvoke.make_false());
		
		public static bdd ithvar(UInt32 i) {
			return new bdd(SylvanSharpPInvoke.ithvar(i));
		}
		
		public static BDDVAR var(this bdd b) {
			return SylvanSharpPInvoke.var(b.Id);
		}
		
		public static bdd varbdd(this bdd b) {
			return new bdd(SylvanSharpPInvoke.var_bdd(b.Id));
		}
		
		public static bdd high(this bdd b) {
			return new bdd(SylvanSharpPInvoke.high(b.Id));
		}
		
		public static bdd low(this bdd b) {
			return new bdd(SylvanSharpPInvoke.low(b.Id));
		}
		
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
			SylvanSharpPInvoke.init_lace(lace_threads, lace_stack);
			SylvanSharpPInvoke.init_package(table_size, max_tablesize, cachesize, max_cachesize);
			SylvanSharpPInvoke.set_granularity(granularity);
		}
	}
}
