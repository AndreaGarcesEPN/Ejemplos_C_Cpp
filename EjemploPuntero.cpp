#include <stdio.h>

main()
{
	int n = 75;
	int *p = &n;
	printf("n = %d, &n = %p \n", n, &n, p);
	printf("p = %p, &p = %p, *p = %d \n", p, &p, *p);
}
