#include "lace.h"

void 
lace_sharp_init_lace(int threads, size_t dqsize) {
    lace_init(threads, dqsize);
}

void 
lace_sharp_init_worker(int worker, size_t dqsize) {
    lace_init_worker(worker, dqsize);
}

void 
lace_sharp_steal_loop() {
	lace_run_default_worker();
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