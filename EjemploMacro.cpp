#include <stdio.h>
#define fesp(x) (x*x + 2*x - 1)

int main()
{
	float x;
	for(x = 0.0; x <= 6.5; x+= 0.3)
	printf("\t f(%.1f) = %6.2f ", x, fesp (x));
}
