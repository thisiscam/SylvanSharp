add_library(sylvan_native MODULE
	wrapper.c
)
target_link_libraries(sylvan_native sylvan)
