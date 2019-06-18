#include<cstdlib>
#include<string.h>
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
	
	cout << "Los valores del cliente 0 son: " << cliente_0.nombre << ", " 
	<< cliente_0.numUnidades << ", " << cliente_0.precio << ", " 
	<< cliente_0.estado << endl;
	
	cout << "Los valores del cliente 1 son: " << cliente_1.nombre << ", " 
	<< cliente_1.numUnidades << ", " << cliente_1.precio << ", " 
	<< cliente_1.estado << endl;
	
	cout << "Los valores del cliente 2 son: " << cliente_2.nombre << ", " 
	<< cliente_2.numUnidades << ", " << cliente_2.precio << ", " 
	<< cliente_2.estado << endl;
	
	cout << "Los valores del cliente 3 son: " << cliente_3.nombre << ", " 
	<< cliente_3.numUnidades << ", " << cliente_3.precio << ", " 
	<< cliente_3.estado << endl;
	
	cout << "Los valores del cliente 4 son: " << cliente_4.nombre << ", " 
	<< cliente_4.numUnidades << ", " << cliente_4.precio << ", " 
	<< cliente_4.estado << endl;
	
	int unidades = cliente_1.numUnidades;
	
	strcpy(cliente_4.nombre, "Marcelo Vicente");
	cliente_4.numUnidades = 17;
	cliente_4.precio = 3.58;
	cliente_4.estado = 'A';
	
	cout << "Los nuevos valores del cliente 4 son: " << cliente_4.nombre << ", " 
	<< cliente_4.numUnidades << ", " << cliente_4.precio << ", " 
	<< cliente_4.estado << endl;
	
	system("PAUSE");
	return EXIT_SUCCESS;
}
