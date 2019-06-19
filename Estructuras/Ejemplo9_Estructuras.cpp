#include<iostream>

using namespace std;

struct Cliente
{
	char nombre[30];
	int unidades;
	double precio;
	char estado;
};

Cliente ProcesarCliente(Cliente mi_cliente)
{
	cout << "Cliente: ";
	cin.getline(mi_cliente.nombre, 30);
	cout << "Unidades: ";
	cin >> mi_cliente.unidades;
	cout << "Precio: ";
	cin >> mi_cliente.precio;
	cout << "Estado (M = Moroso, A = Atrasado, P = Pagado): ";
	cin >> mi_cliente.estado;
	return mi_cliente;
}

int main()
{
	Cliente cliente;
	Cliente respuesta_cliente = ProcesarCliente(cliente);
	cout << "Cliente: " << respuesta_cliente.nombre << endl << "Unidades: "
	<< respuesta_cliente.unidades << endl << "Precio: " << respuesta_cliente.precio << endl
	<< "Estado: " << respuesta_cliente.estado << endl;
	return 0;
}


