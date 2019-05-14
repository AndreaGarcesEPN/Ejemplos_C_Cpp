#include <iostream>
using namespace std;

int main()
{
	int acumulador;
	int valor;
	
	cout << "Ingrese los valores" << endl;
	acumulador = 0;
	do
	{
		cin >> valor;
		if(valor >= 0)
		{
		acumulador = acumulador + valor;
		}	
	} while (valor >= 0);

	cout << acumulador;
	
}

