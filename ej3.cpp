#include <iostream>
#include <cmath>
using namespace std;

int cubos(int valor);
float raices(int valor);

int cubos(int acumulador)
{
	int resultado;
	resultado = pow(acumulador,3);
}

float raices(int acumulador)
{
	float resultado = sqrtf(acumulador);
}	
	
int main()
{
	int acumulador;
	cout << "Cuadrados y raíces de los números del 0 al 30" << endl;
	acumulador = 0;
	do
	{
		cout << acumulador << cubos(acumulador) << "		" << raices(acumulador) << endl;
		acumulador = acumulador + 1;
	}
	while (acumulador < 30);
}
