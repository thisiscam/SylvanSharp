#include "lace.h"

typedef void (*laced_function_0)(int);
typedef void (*laced_function_1)(int, void*);
typedef void (*laced_function_2)(int, void*, void*);

VOID_TASK_DECL_2(lace_spawn_f_wrapper0, laced_function_0, int);
VOID_TASK_IMPL_2(lace_spawn_f_wrapper0, laced_function_0, f, int, i) { f(i); }
VOID_TASK_DECL_3(lace_spawn_f_wrapper1, laced_function_1, int, void*);
VOID_TASK_IMPL_3(lace_spawn_f_wrapper1, laced_function_1, f, int, i, void*, arg0) { f(i,arg0); }
VOID_TASK_DECL_4(lace_spawn_f_wrapper2, laced_function_2, int, void*, void*);
VOID_TASK_IMPL_4(lace_spawn_f_wrapper2, laced_function_2, f, int, i, void*, arg0, void*, arg1) { f(i,arg0,arg1); }

void lace_parallel_for_0(laced_function_0 f, int iter)
{
    LACE_ME;
    int i;
    for(i=0; i<iter; i++) {
        SPAWN(lace_spawn_f_wrapper0, f, i);
    }
    for(i=0; i<iter; i++) {
        SYNC(lace_spawn_f_wrapper0);
    }
}

void lace_parallel_for_1(laced_function_1 f, int iter, void** args0)
{
    LACE_ME;
    int i;
    for(i=0; i<iter; i++) {
        SPAWN(lace_spawn_f_wrapper1, f, i, args0[i]);
    }
    for(i=0; i<iter; i++) {
        SYNC(lace_spawn_f_wrapper1);
    }
}

void lace_parallel_for_2(laced_function_2 f, int iter, void** args0, void** args1)
{
    LACE_ME;
    int i;
    for(i=0; i<iter; i++) {
        SPAWN(lace_spawn_f_wrapper2, f, i, args0[i], args1[i]);
    }
    for(i=0; i<iter; i++) {
        SYNC(lace_spawn_f_wrapper2);
    }
}
