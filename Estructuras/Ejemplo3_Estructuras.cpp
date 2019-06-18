#include<cstdlib>
#include<iostream>

using namespace std;

struct Cliente
{
	char nombre[20];
	int numUnidades;
	float precio;
	char estado;
} cliente_0 = {"Andrea Garcés", 40, 65.5, 'P'};

int main()
{
	Cliente cliente_1 = {"Adrian Eguez", 12, 10.3, 'M'};
	Cliente cliente_2 = {"Julián Velasco", 13, 10, 'A'}; 
	Cliente cliente_3 = {"Rosa García", 45, 30, 'P'};
	Cliente cliente_4;
	cliente_4 = cliente_1;

	Cliente lista[100];
	
	system("PAUSE");
	return EXIT_SUCCESS;
}
