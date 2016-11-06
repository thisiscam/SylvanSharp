add_library(sylvan_native SHARED
	sylvan_wrapper.c
	lace_wrapper.c
)
target_link_libraries(sylvan_native sylvan)
