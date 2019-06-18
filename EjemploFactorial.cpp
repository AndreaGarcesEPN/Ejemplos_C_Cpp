#include <stdio.h>

using namespace std;

//Ejemplo con operador ternario
int FactorialTernario(int n)
{
	return (n <= 1)? 1 : n * FactorialTernario(n - 1);
}

//Ejemplo de función de forma recursiva
int FactorialRecursivo(int n)
{
	if(n <= 1)
	{
		return 1;
	}
	return n * FactorialRecursivo(n - 1);
}

//Ejemplo de función de foma iterativa
int FactorialIterativo(int n)
{
	int fact, m;
	for(m = n, fact = 1; n > 1; fact *= n--)
	{
	}
	return fact;
}

int main()
{
	long int n, m, fact;
	do
	{
		printf("\nFactorial del numero n, entre 2 y 10: ");
		scanf("%ld", &n);
	}while ((n < 2) || (n > 10));
	fact = FactorialIterativo(n);
	printf("%ld! = %ld", n, fact);
	return 0;
}
