#include<iostream>
#include<iomanip>

using namespace std;

struct Cliente
{
	int codigo;
	char nombre[30];
	double saldo;
};

void LeerCliente(Cliente mi_cliente[])
{
	char limpiarBuffer[5];
	for(int i = 0; i < 4; i++)
	{
		cout << "Codigo: ";
		cin >> mi_cliente[i].codigo;
		cin.sync();
		cout << "Cliente " << i << " : ";
		cin.getline(mi_cliente[i].nombre, 30);
		cout << "Saldo: ";
		cin >> mi_cliente[i].saldo;
		cin.getline(limpiarBuffer, 5);
	}
}

Cliente* Operaciones(Cliente mi_cliente[])
{
	for(int i = 0; i < 4; i++)
	{
		if(mi_cliente[i].saldo < 10)
		{
			mi_cliente[i].saldo -= 1;
		}
		if(mi_cliente[i].saldo >= 10 && mi_cliente[i].saldo < 100)
		{
			mi_cliente[i].saldo *= 2;
		}
		if(mi_cliente[i].saldo > 100)
		{
			mi_cliente[i].saldo = mi_cliente[i].saldo * mi_cliente[i].saldo * mi_cliente[i].saldo;
		}
	}
	return mi_cliente;
}

void DatosCliente(Cliente mi_cliente[])
{
	cout << endl << "Los datos de los clientes son:" << endl;
	cout << setw(10) << "Codigo" << setw(10) << "Nombre" << setw(10) << "Saldo" << endl;
	for(int i = 0; i < 3; i++)
	{
		cout << setw(10) << mi_cliente[i].codigo << setw(10) 
		<< mi_cliente[i].nombre << setw(10) << setprecision(2) << mi_cliente[i].saldo << endl;
	}
	cout << endl;
}

int main()
{
	Cliente *cliente = new Cliente[4]; 
	LeerCliente(cliente);
	Operaciones(cliente);
	DatosCliente(cliente);
	return 0;
}
