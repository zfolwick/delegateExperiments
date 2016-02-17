all:
	gcc -g -c -Werror -Wall -fPIC case.c -o case.o
	gcc -shared -o case.so case.o
