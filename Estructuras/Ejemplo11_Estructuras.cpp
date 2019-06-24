#include<iostream>

using namespace std;

struct Cliente
{
	char nombre[30];
	int unidades;
	double precio;
	char estado;
};

void ProcesarCliente(Cliente mi_cliente[])
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
}

void DatosCliente(Cliente mi_cliente[])
{
	cout << endl << "Los datos de los clientes son" << endl;
	for(int i = 0; i < 3; i++)
	{
		cout << endl << "Cliente: " << mi_cliente[i].nombre << endl << "Unidades: "
		<< mi_cliente[i].unidades << endl << "Precio: " << mi_cliente[i].precio << endl
		<< "Estado: " << mi_cliente[i].estado << endl;
	}
	cout << endl;
}

int main()
{
	Cliente *cliente = new Cliente[100];
	ProcesarCliente(cliente);
	DatosCliente(cliente);
	delete[] cliente;
	return 0;
}


