﻿using System;
using System.Runtime.InteropServices;

using BDDVAR = System.Int32;
using BDD = System.Int64;
using size_t=System.UInt64;

namespace SylvanSharp
{
	public static partial class SylvanSharp
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
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_nithvar")]
		public static extern BDD nithvar(BDDVAR var);
		
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
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_exists")]
		public static extern BDD exists(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_constrain")]
		public static extern BDD constrain(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_restrict")]
		public static extern BDD restrict(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_imp")]
		public static extern BDD imp(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_invimp")]
		public static extern BDD invimp(BDD a, BDD b);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_biimp")]
		public static extern BDD biimp(BDD a, BDD b);
		
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
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_init_package")]
		public static extern void init_package(size_t tablesize, size_t max_tablesize, size_t cachesize, size_t max_cachesize);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_package_is_running")]
		public static extern bool package_is_running();

		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_quit")]
		public static extern void quit();

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
		
		public delegate void gc_hook_cb();
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_gc_hook_pregc")]
		public static extern void sylvan_gc_hook_pregc(gc_hook_cb cb);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_sharp_hook_postgc")]
		public static extern void sylvan_gc_hook_postgc(gc_hook_cb cb);
		
		[global::System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint="sylvan_csharp_gc_hook_main")]
		public static extern void sylvan_gc_hook_main(gc_hook_cb cb);
	}
}