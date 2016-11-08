using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SylvanSharp;

namespace TestSylvanSharp
{
	class MainClass
	{
		private static bdd PeformTreeAnd(int start, int end)
		{
			Console.WriteLine("start {0} end {1}", start, end);
			if(start == end) {
				return bdd.bddtrue;
			} else if(start == end - 1) {
				return bdd.ithvar(start);
			} else {
				var mid = (end - start) / 2 + start;
				bdd r1 = null, r2 = null;
				r1.PrintDot();
				r2.PrintDot();
				return r1.And(r2);
			}
		} 
	
		public static void TestSingleThread()
		{
			SylvanSharp.Lace.Init(0, 100000);
			SylvanSharp.SylvanSharp.init(22, 22, 22, 22, 1);
			var t = bdd.bddtrue;
			var f = bdd.bddfalse;
			var a = bdd.ithvar(0);
			var b = bdd.ithvar(1);
			var a_and_b = a.And(b);
			var a_and_not_b = a.And(b.Not());
			a_and_not_b.PrintDot();

			Assert(!a_and_b.EqualEqual(t));
			Assert(a_and_b.And(a_and_not_b).EqualEqual(f));
			
			//bdd zero_to_hundred = PeformTreeAnd(0, 3);
			//SylvanSharpPInvoke.print_dot(zero_to_hundred.Id);
			var array = new bdd[100];
			Lace.ParallelFor((i) => { array[i] = bdd.ithvar(i).And(bdd.ithvar(i+1)); }, array.Length);
			int x = 0;
			Lace.ParallelFor((i) => {
				Console.WriteLine("{0} {0}", i, array[i]);
				Lace.LockRegion(mutex, () => {
					Console.WriteLine(i);
					x += i;
				});
			}, array.Length);
			Console.WriteLine("Acc x = {0}", x);
			SylvanSharp.SylvanSharp.quit();
			Lace.Exit();
		}
		
		private static void Assert(bool b)
		{
			if(!b) {
				throw new Exception("failed");
			}
		}
		
		private static IntPtr mutex = Lace.CreateMutex();
		
		public static void Main(string[] args)
		{
			TestSingleThread();
		}
	}
}
