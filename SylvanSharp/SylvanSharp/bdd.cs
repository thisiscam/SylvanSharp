using System;
namespace SylvanSharp
{
	public class bdd
	{
		private Int64 id;
		
		public bdd(Int64 id)
		{
			this.id = id;
			SylvanSharpPInvoke.protect(ref this.id);
		}
		
		~bdd() {
			SylvanSharpPInvoke.unprotect(ref this.id);
		}
		
		public Int64 Id { get { return id; } }
		
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
