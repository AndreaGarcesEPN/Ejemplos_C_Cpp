#include<iostream>

using namespace std;

void Calcular(int* valor)
{
	*valor *= *valor;
}

int main()
{
	int x = 2;
	int *valor = &x;
	Calcular(&x);
	cout << *valor;
	return 0;
}
