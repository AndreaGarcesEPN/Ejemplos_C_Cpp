#include<iostream>
#include<string.h>

using namespace std;

struct Cliente
{
	char nombre[30];
	int unidades;
	double precio;
	char estado;
};

Cliente* ProcesarCliente(Cliente mi_cliente[])
{
	char limpiarBuffer[4];
	for(int i = 0; i < 3; i++)
	{
		cout << "Cliente " << i << ": ";
		cin.getline(mi_cliente[i].nombre, 30);
		cout << "Unidades: ";
		cin >> mi_cliente[i].unidades;
		cout << "Precio: ";
		cin >> mi_cliente[i].precio;
		cout << "Estado (M = Moroso, A = Atrasado, P = Pagado): ";
		cin >> mi_cliente[i].estado;
		cin.getline(limpiarBuffer, 4);
	}
	return mi_cliente;
}

void DatosCliente(Cliente mi_cliente[])
{
	cout << endl << "Los datos de los clientes son" << endl;
	for(int i = 0; i < 3; i++)
	{
		cout << endl << "Cliente " << i << ": " <<  mi_cliente[i].nombre << endl << "Unidades: "
		<< mi_cliente[i].unidades << endl << "Precio: " << mi_cliente[i].precio << endl
		<< "Estado: " << mi_cliente[i].estado << endl;
	}
	cout << endl;
}
	

int main()
{
	Cliente *cliente = new Cliente[100];
	Cliente *cliente_2 = ProcesarCliente(cliente);
	strcpy(cliente[0].nombre, "ABC");
	DatosCliente(cliente);
	delete[] cliente;
	return 0;
}


