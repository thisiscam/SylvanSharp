#include <stdbool.h>
#include "sylvan.h"

void
sylvan_sharp_set_granularity(int granularity)
{
	sylvan_set_granularity(granularity);
}

int
sylvan_sharp_get_granularity()
{
	return sylvan_get_granularity();
}

BDD
sylvan_sharp_make_true()
{
    return sylvan_true;
}

BDD
sylvan_sharp_make_false()
{
    return sylvan_false;
}

BDD
sylvan_sharp_ithvar(BDDVAR var)
{
    return sylvan_ithvar(var);
}

BDD
sylvan_sharp_nithvar(BDDVAR var)
{
    return sylvan_nithvar(var);
}

BDD
sylvan_sharp_not(BDD bdd)
{
    return sylvan_not(bdd);
}

BDD
sylvan_sharp_and(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_and(a, b);
}

BDD
sylvan_sharp_or(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_or(a, b);
}

BDD
sylvan_sharp_xor(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_xor(a, b);
}

BDD
sylvan_sharp_ite(BDD a, BDD b, BDD c)
{
    LACE_ME;
    return sylvan_ite(a, b, c);
}

BDD
sylvan_sharp_invimp(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_invimp(a, b);
}

BDD
sylvan_sharp_biimp(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_biimp(a, b);
}

BDD
sylvan_sharp_diff(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_diff(a, b);
}

BDD
sylvan_sharp_less(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_less(a, b);
}

BDD
sylvan_sharp_exists(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_exists(a, b);
}

// BDD
// sylvan_sharp_next(BDD a, BDD b, BDD variables)
// {
//     return sylvan_relprod_paired(a, b, variables);
// }

BDD
sylvan_sharp_constrain(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_constrain(a, b);
}

BDD
sylvan_sharp_restrict(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_restrict(a, b);
}

BDD
sylvan_sharp_imp(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_imp(a, b);
}

BDD
sylvan_sharp_support(BDD bdd)
{
    LACE_ME;
    return sylvan_support(bdd);
}

BDD
sylvan_sharp_var_bdd(BDD bdd)
{
    return sylvan_ithvar(sylvan_var(bdd));
}

BDD
sylvan_sharp_high(BDD bdd)
{
    LACE_ME;
    return sylvan_high(bdd);
}

BDD
sylvan_sharp_low(BDD bdd)
{
    return sylvan_low(bdd);
}

BDDVAR
sylvan_sharp_var(BDD bdd)
{
    return sylvan_var(bdd);
}

void
sylvan_sharp_addref(BDD bdd)
{
    sylvan_ref(bdd);
}

void 
sylvan_sharp_delref(BDD bdd)
{
    sylvan_deref(bdd);
}

void
sylvan_sharp_protect(BDD *bdd)
{
    sylvan_protect(bdd);
}

void 
sylvan_sharp_unprotect(BDD *bdd)
{
    sylvan_unprotect(bdd);
}

void
sylvan_sharp_satcount(BDD bdd, BDD variables)
{
    LACE_ME;
    sylvan_satcount(bdd, variables);
}

size_t
sylvan_sharp_nodecount(BDD bdd)
{
    LACE_ME;
    return sylvan_nodecount(bdd); // note: unsigned/signed mismatch...
}

void
sylvan_sharp_init_package(size_t table_size, size_t max_tablesize, size_t cachesize, size_t max_cachesize)
{
    sylvan_init_package(table_size, max_tablesize, cachesize, max_cachesize);
    sylvan_init_bdd();
}

bool
sylvan_sharp_package_is_running()
{
    return sylvan_package_is_running();
}

void
sylvan_sharp_quit()
{
    sylvan_quit();
}

size_t sylvan_sharp_serialize_add(BDD bdd) {
    return sylvan_serialize_add(bdd);
}

size_t sylvan_sharp_serialize_get(BDD bdd) {
    return sylvan_serialize_get(bdd);
}

BDD sylvan_sharp_serialize_get_reversed(size_t value) {
    return sylvan_serialize_get_reversed(value);
}

void sylvan_sharp_serialize_reset(void) {
    sylvan_serialize_reset();
}

void sylvan_sharp_serialize_totext(const char *out) {
    FILE* f = fopen(out, "w+");
    sylvan_serialize_totext(f);
    fclose(f);
}

void sylvan_sharp_serialize_tofile(const char *out) {
    FILE* f = fopen(out, "w+");
    sylvan_serialize_tofile(f);
    fclose(f);
}

void sylvan_sharp_serialize_fromfile(const char *in) {
    FILE* f = fopen(in, "r");
    sylvan_serialize_fromfile(f);
    fclose(f);
}

void
sylvan_sharp_print(BDD bdd)
{
    sylvan_print(bdd);
}

void
sylvan_sharp_fprint(const char* filename, BDD bdd)
{
    FILE *f = fopen(filename, "w");
    sylvan_fprint(f, bdd);
    fclose(f);
}

void
sylvan_sharp_print_dot(BDD bdd)
{
    sylvan_printdot(bdd, NULL);
}

void
sylvan_sharp_fprint_dot(const char* filename, BDD bdd)
{
    FILE *f = fopen(filename, "w");
    sylvan_fprintdot(f, bdd);
    fclose(f);
}

// BDD
// sylvan_sharp_make_uion_piar(jlongArray arr)
// {
//     jsize len = (*env)->GetArrayLength(env, arr);
//     if (len == 0) return (jlong)sylvan_false;

//     jlong *dest = (*env)->GetLongArrayElements(env, arr, 0);
//     BDD result = CALL(union_par, (BDD*)dest, 0, len-1);
//     (*env)->ReleaseLongArrayElements(env, arr, dest, 0);

//     return result;
// }

void
sylvan_sharp_disable_gc()
{
    sylvan_gc_disable();
    return;
}
void
sylvan_sharp_enable_gc()
{
    sylvan_gc_enable();
    return;
}

void
sylvan_sharp_gc_hook_pregc(gc_hook_cb callback)
{
    sylvan_gc_hook_pregc(callback);
}

void
sylvan_sharp_hook_postgc(gc_hook_cb callback)
{
    sylvan_gc_hook_postgc(callback);
}

void
sylvan_csharp_gc_hook_main(gc_hook_cb callback)
{
    sylvan_gc_hook_main(callback);
}

/* addref extensions */
BDD sylvan_sharp_not_addref(BDD bdd) { return sylvan_ref(sylvan_not(bdd)); }

BDD sylvan_sharp_and_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_and(a, b)); }

BDD sylvan_sharp_or_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_or(a, b)); }

BDD sylvan_sharp_xor_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_xor(a, b)); }

BDD sylvan_sharp_ite_addref(BDD a, BDD b, BDD c) { return sylvan_ref(sylvan_sharp_ite(a, b, c)); }

BDD sylvan_sharp_diff_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_diff(a, b)); }

BDD sylvan_sharp_less_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_less(a, b)); }

BDD sylvan_sharp_exists_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_exists(a, b)); }

BDD sylvan_sharp_constrain_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_constrain(a, b)); }

BDD sylvan_sharp_restrict_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_restrict(a, b)); }

BDD sylvan_sharp_imp_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_imp(a, b)); }

BDD sylvan_sharp_invimp_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_invimp(a, b)); }

BDD sylvan_sharp_biimp_addref(BDD a, BDD b) { return sylvan_ref(sylvan_sharp_biimp(a, b)); }

BDD sylvan_sharp_support_addref(BDD bdd) { return sylvan_ref(sylvan_sharp_support(bdd)); }

BDD sylvan_sharp_var_bdd_addref(BDD bdd) { return sylvan_ref(sylvan_sharp_var_bdd(bdd)); }

BDD sylvan_sharp_high_addref(BDD bdd) { return sylvan_ref(sylvan_sharp_high(bdd)); }

BDD sylvan_sharp_low_addref(BDD bdd) { return sylvan_ref(sylvan_sharp_low(bdd)); }

void 
sylvan_sharp_delref_if_running(BDD bdd)
{
    if(sylvan_package_is_running()) {
        sylvan_deref(bdd);
    }
}
/* end addref extensions */