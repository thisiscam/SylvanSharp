using System;
using System.Collections.Generic;
using BDD = System.Int64;

namespace SylvanSharp
{
	public class bdd
	{
		public static readonly bdd bddtrue = new bdd(SylvanSharp.make_true(), false);
		public static readonly bdd bddfalse = new bdd(SylvanSharp.make_false(), false);
		
		private BDD _id;
		
		public BDD Id { get { return _id; } }
		
		public bdd(BDD id):this(id, true) {}
		
		public bdd(BDD id, bool addref)
		{
			this._id = id;
			if(addref) {
				SylvanSharp.addref(this._id);
			}
		}
		
		~bdd()
		{
			/* Use extension "del_if_running", since Finalizer might trigger after lace is shut down! */
			SylvanSharp.delref_if_running(this._id);
		}
				
		public bdd And(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_and_addref(this._id, r._id), false);
		}

		public bdd Xor(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_xor_addref(this._id, r._id), false);
		}

		public bdd Or(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_or_addref(this._id, r._id), false);
		}

		public bdd Not()
		{
			return new bdd(SylvanSharp.sylvan_sharp_not_addref(this._id), false);
		}

		public bdd Imp(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_imp_addref(this._id, r._id), false);
		}
		
		public bdd Biimp(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_biimp_addref(this._id, r._id), false);
		}

		public bdd Diff(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_diff_addref(this.Id, r.Id), false);
		}

		public bdd GreaterThan(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_diff_addref(this.Id, r.Id), false);
		}

		public bdd LessThan(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_less_addref(this.Id, r.Id), false);
		}

		public bdd InvImplies(bdd r)
		{
			return new bdd(SylvanSharp.sylvan_sharp_invimp_addref(this.Id, r.Id), false);
		}
		
		public bool EqualEqual(bdd r)
		{
			return this._id == r._id;
		}

		public bool NotEqual(bdd r)
		{
			return this._id != r._id;
		}
		
#region extensions
		public static bdd ithvar(int arg0) {
			return new bdd(SylvanSharp.ithvar(arg0), false);
		}
		
		public static bdd nithvar(int arg0) {
			return new bdd(SylvanSharp.nithvar(arg0), false);
		}
		
		public static bdd mark_ithvar_npure_bool(int arg0) {
			throw new Exception("Not implemented");
		}
		
		public bool not_pure_bool() {
			return false;
		}
		
		public bdd Low() {
			return new bdd(SylvanSharp.sylvan_sharp_low_addref(this.Id), false);
		}
		
		public bdd High() {
			return new bdd(SylvanSharp.sylvan_sharp_high_addref(this.Id), false);
		}
		public int Var() {
        	return SylvanSharp.var(this._id);
		}
        
        private string ToStringHelper(Dictionary<BDD, string> cache)
        {
        	if (this.EqualEqual (bddtrue)) {
                return "t";
            } else if (this.EqualEqual (bddfalse)) {
                return "f";
            } else {
            	if(!cache.ContainsKey(_id)) {
	                var ret = String.Format("({0} {1} {2})", Var(), Low().ToStringHelper(cache), High().ToStringHelper(cache));
	                cache[_id] = ret;
                }
                return cache[_id];
            }
        }
        
        public override string ToString()
		{
			if(SylvanSharp.nodecount(_id) < 100) {
            	return ToStringHelper(new Dictionary<BDD, string>());
            } else {
            	return "bdd";
			}
		}
		
		public void PrintDot()
		{
			SylvanSharp.print_dot(this._id);
		}
#endregion
	}
}
