#include <stdlib.h>
#include "lace.h"

typedef void (*laced_function_0)(void);
typedef void (*laced_function_1)(int);

VOID_TASK_DECL_1(lace_spawn_f_wrapper0, laced_function_0);
VOID_TASK_IMPL_1(lace_spawn_f_wrapper0, laced_function_0, f) { f(); }
VOID_TASK_DECL_2(lace_spawn_f_wrapper1, laced_function_1, int);
VOID_TASK_IMPL_2(lace_spawn_f_wrapper1, laced_function_1, f, int, i) { f(i); }

void lace_sharp_parallel_for_0(laced_function_1 f, int iter)
{
    LACE_ME;
    int i;
    for(i=0; i<iter; i++) {
        SPAWN(lace_spawn_f_wrapper1, f, i);
    }
    for(i=0; i<iter; i++) {
        SYNC(lace_spawn_f_wrapper1);
    }
}

#ifndef cas
#define cas(ptr, old, new) (__sync_bool_compare_and_swap((ptr),(old),(new)))
#endif

typedef volatile int __attribute__((aligned(64))) lace_mutex;

lace_mutex* lace_sharp_create_mutex() {
	lace_mutex* ret = malloc(sizeof(lace_mutex));
	*ret = 1;
	return ret;
}

void lace_sharp_free_mutex(lace_mutex* mutex) {
	free((void*)mutex);
}

void lace_sharp_lock_region(lace_mutex* mutex, laced_function_0 f) {
	LACE_ME;
	while(!cas(mutex, 1, 0)) {
		lace_steal_loop((int*)mutex);
	}
	f();
	*mutex = 1;
}

