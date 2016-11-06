#include "lace.h"

void 
lace_sharp_init_lace(int threads, size_t stacksize) {
    lace_init(threads, stacksize);
    lace_startup(0, NULL, NULL);
}

void
lace_sharp_exit_lace() {
    lace_exit();
}


typedef void (*laced_function_0)(int);

VOID_TASK_DECL_2(lace_spawn_f_wrapper0, laced_function_0, int);
VOID_TASK_IMPL_2(lace_spawn_f_wrapper0, laced_function_0, f, int, i) { f(i); }

void lace_sharp_parallel_for_0(laced_function_0 f, int iter)
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