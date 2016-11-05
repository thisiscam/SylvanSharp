using System;
using SylvanSharp;

namespace TestSylvanSharp
{
	class MainClass
	{
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
			Assert(a_and_b.Or(a_and_not_b).EqualEqual(t));
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
