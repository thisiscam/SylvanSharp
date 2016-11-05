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
    return sylvan_or(a, b);
}

BDD
sylvan_sharp_ite(BDD a, BDD b, BDD c)
{
    LACE_ME;
    return sylvan_ite(a, b, c);
}

BDD
sylvan_sharp_equals(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_equiv(a, b);
}

BDD
sylvan_sharp_not_equals(BDD a, BDD b)
{
    LACE_ME;
    return sylvan_xor(a, b);
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
sylvan_sharp_implies(BDD a, BDD b)
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
sylvan_sharp_init_lace(int threads, size_t stacksize) {
	lace_init(threads, stacksize);
	lace_startup(0, NULL, NULL);
    LACE_ME;
}

void
sylvan_sharp_init_package(size_t table_size, size_t max_tablesize, size_t cachesize, size_t max_cachesize)
{
    sylvan_init_package(table_size, max_tablesize, cachesize, max_cachesize);
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