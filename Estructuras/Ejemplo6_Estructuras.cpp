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
	
	Cliente *cliente_4;
	cliente_4 = (Cliente*)malloc(sizeof(Cliente));
	strcpy(cliente_4->nombre, "Marcelo Vicente");
	cliente_4->numUnidades = 17;
	cliente_4->precio = 3.58;
	cliente_4->estado = 'A';
	
	cout << "Los valores del cliente 4 son: " << cliente_4->nombre << ", " 
	<< cliente_4->numUnidades << ", " << cliente_4->precio << ", " 
	<< cliente_4->estado << endl;
	
	free(cliente_4);
	
	Cliente *cliente_5 = new Cliente;
	strcpy(cliente_5->nombre, "Fernanda Proaño");
	cliente_5->numUnidades = 85;
	cliente_5->precio = 45.21;
	cliente_5->estado = 'P';
	
	cout << "Los valores del cliente 5 son: " << cliente_5->nombre << ", " 
	<< cliente_5->numUnidades << ", " << cliente_5->precio << ", " 
	<< cliente_5->estado << endl;
	
	delete cliente_5;
	
	system("PAUSE");
	return EXIT_SUCCESS;
}
