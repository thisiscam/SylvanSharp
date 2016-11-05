using System;
using BDD = System.Int64;

namespace SylvanSharp
{
	public class bdd
	{
		private BDD id;
		
		public bdd(BDD id)
		{
			this.id = id;
			SylvanSharpPInvoke.addref(this.id);
		}
		
		~bdd() {
			SylvanSharpPInvoke.delref(this.id);
		}
		
		public BDD Id { get { return id; } }
		
		public bdd And(bdd other) {
			return new bdd(SylvanSharpPInvoke.and(this.id, other.id));
		}
		
		public bdd Or(bdd other) {
			return new bdd(SylvanSharpPInvoke.or(this.id, other.id));
		}
		
		public bdd Xor(bdd other) {
			return new bdd(SylvanSharpPInvoke.xor(this.id, other.id));
		}
		
		public bdd Not() {
			return new bdd(SylvanSharpPInvoke.not(this.id));
		}
		
		public bool EqualEqual(bdd other) {
			return this.id == other.id;
		}
	}
}
