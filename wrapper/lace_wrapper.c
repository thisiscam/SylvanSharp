#include "lace.h"

typedef void (*laced_function_0)();
typedef void (*laced_function_1)(void*);
typedef void (*laced_function_2)(void*, void*);

VOID_TASK_DECL_1(lace_spawn_f_wrapper0, laced_function_0);
VOID_TASK_IMPL_1(lace_spawn_f_wrapper0, laced_function_0, f) { f(); }
VOID_TASK_DECL_2(lace_spawn_f_wrapper1, laced_function_1, void*);
VOID_TASK_IMPL_2(lace_spawn_f_wrapper1, laced_function_1, f, void*, arg0) { f(arg0); }
VOID_TASK_DECL_3(lace_spawn_f_wrapper2, laced_function_2, void*, void*);
VOID_TASK_IMPL_3(lace_spawn_f_wrapper2, laced_function_2, f, void*, arg0, void*, arg1) { f(arg0,arg1); }

void lace_parallel_for_0(laced_function_0 f, int iter)
{
    LACE_ME;
    int i;
    for(i=0; i<iter; i++) {
        SPAWN(lace_spawn_f_wrapper0, f);
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
        SPAWN(lace_spawn_f_wrapper1, f, args0[i]);
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
        SPAWN(lace_spawn_f_wrapper2, f, args0[i], args1[i]);
    }
    for(i=0; i<iter; i++) {
        SYNC(lace_spawn_f_wrapper2);
    }
}
