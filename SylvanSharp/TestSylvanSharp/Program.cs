using System;
using System.Threading.Tasks;
using SylvanSharp;

namespace TestSylvanSharp
{
	class MainClass
	{
		private static bdd PeformTreeAnd(uint start, uint end)
		{
			Console.WriteLine("start {0} end {1}", start, end);
			if(start == end) {
				return Sylvan.bddtrue;
			} else if(start == end - 1) {
				return Sylvan.ithvar(start);
			} else {
				var mid = (end - start) / 2 + start;
				bdd r1 = null, r2 = null;
				Parallel.Invoke(
					() => r1 = PeformTreeAnd(start, mid),
					() => r2 = PeformTreeAnd(mid, end)
				);
				SylvanSharpPInvoke.print_dot(r1.Id);
				SylvanSharpPInvoke.print_dot(r2.Id);
				return r1.And(r2);
			}
		} 
	
		public static void TestSingleThread()
		{
			Sylvan.init(4, 100000, 22, 26, 22, 26, 6);
			var t = Sylvan.bddtrue;
			var f = Sylvan.bddfalse;
			var a = Sylvan.ithvar(0);
			var b = Sylvan.ithvar(1);
			var a_and_b = a.And(b);
			var a_and_not_b = a.And(b.Not());
			SylvanSharpPInvoke.print_dot(a_and_not_b.Id);

			Assert(!a_and_b.EqualEqual(t));
			Assert(a_and_b.And(a_and_not_b).EqualEqual(f));
			
			//bdd zero_to_hundred = PeformTreeAnd(0, 3);
			//SylvanSharpPInvoke.print_dot(zero_to_hundred.Id);
			Parallel.For(0, 10000,
				(i) => Sylvan.ithvar((uint)i).And(b)
			);
		}
		
		private static void Assert(bool b)
		{
			if(!b) {
				throw new Exception("failed");
			}
		}
		
		public static void Main(string[] args)
		{
			TestSingleThread();
		}
	}
}
