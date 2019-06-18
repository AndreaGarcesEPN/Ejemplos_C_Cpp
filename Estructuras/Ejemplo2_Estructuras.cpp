#include<cstdlib>
#include<iostream>

using namespace std;

struct Cliente
{
	char nombre[20];
	int numUnidades;
	float precio;
	char estado;
};

int main()
{
	Cliente cliente_1, cliente_2, cliente_3, cliente_4;
	Cliente lista[100];
	
	cliente_4 = cliente_3 = cliente_2 = cliente_1;
	
	system("PAUSE");
	return EXIT_SUCCESS;
}
