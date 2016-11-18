using System;
using System.Runtime.InteropServices;

using BDDVAR = System.Int32;
using BDD = System.Int64;
using size_t = System.UInt64;
using System.Security;

namespace SylvanSharp
{
	public static partial class SylvanSharp
	{
		const string DLLNAME = "sylvan_native";
		
		[SuppressUnmanagedCodeSecurity]		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_set_granularity")]
		public static extern void set_granularity(int granularity);
		
		[SuppressUnmanagedCodeSecurity]		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_get_granularity")]
		public static extern int get_granularity();
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_make_true")]
		public static extern BDD make_true();
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_make_false")]
		public static extern BDD make_false();
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_ithvar")]
		public static extern BDD ithvar(BDDVAR var);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_nithvar")]
		public static extern BDD nithvar(BDDVAR var);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_not")]
		public static extern BDD not(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_and")]
		public static extern BDD and(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_or")]
		public static extern BDD or(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_xor")]
		public static extern BDD xor(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_ite")]
		public static extern BDD ite(BDD a, BDD b, BDD c);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_exists")]
		public static extern BDD exists(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_constrain")]
		public static extern BDD constrain(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_restrict")]
		public static extern BDD restrict(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_imp")]
		public static extern BDD imp(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_invimp")]
		public static extern BDD invimp(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_biimp")]
		public static extern BDD biimp(BDD a, BDD b);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_support")]
		public static extern BDD support(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_var_bdd")]
		public static extern BDD var_bdd(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_high")]
		public static extern BDD high(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_low")]
		public static extern BDD low(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_var")]
		public static extern BDDVAR var(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_addref")]
		public static extern void addref(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_delref")]
		public static extern void delref(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_protect")]
		public static extern void protect(ref BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_unprotect")]
		public static extern void unprotect(ref BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_satcount")]
		public static extern void satcount(BDD bdd, BDD variables);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_nodecount")]
		public static extern size_t nodecount(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_init_package")]
		public static extern void init_package(size_t tablesize, size_t max_tablesize, size_t cachesize, size_t max_cachesize);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_package_is_running")]
		public static extern bool package_is_running();

		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_quit")]
		public static extern void quit();

		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_print")]
		public static extern void print(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_fprint")]
		public static extern void fprint(string filename, BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_print_dot")]
		public static extern void print_dot(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_fprint_dot")]
		public static extern void fprint_dot(string filename, BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_disable_gc")]
		public static extern void disable_gc();
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_enable_gc")]
		public static extern void enable_gc();
		
		public delegate void gc_hook_cb();
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_gc_hook_pregc")]
		public static extern void sylvan_gc_hook_pregc(gc_hook_cb cb);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_hook_postgc")]
		public static extern void sylvan_gc_hook_postgc(gc_hook_cb cb);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_csharp_gc_hook_main")]
		public static extern void sylvan_gc_hook_main(gc_hook_cb cb);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_serialize_add")]
		public static extern size_t sylvan_serialize_add(BDD bdd);

		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_serialize_get")]
		public static extern size_t sylvan_serialize_get(BDD bdd);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_serialize_get_reversed")]
		public static extern BDD sylvan_serialize_get_reversed(size_t value);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_serialize_reset")]
		public static extern void sylvan_serialize_reset();
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_serialize_totext")]
		public static extern void sylvan_serialize_totext(string o);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_serialize_tofile")]
		public static extern void sylvan_serialize_tofile(string o);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_serialize_fromfile")]
		public static extern void sylvan_serialize_fromfile(string i);
		
		[SuppressUnmanagedCodeSecurity]
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_stats_report")]
		public static extern void sylvan_stats_report(string filename);
	}
}
