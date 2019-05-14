#include<iostream>
#include<locale.h>
using namespace std;

void saludar(string valor);
int suma(int valor1, int valor2);
int suma1(int valor1, int valor2, int valor3);

void saludar(string valor) {
	cout << "Hola " << valor << endl;
}

int suma(int valor1, int valor2) {
	int retorno;
	retorno = valor1+valor2;
	return retorno;
}

int suma1(int valor1, int valor2, int valor3) {
	int retorno1;
	retorno1 = valor1+valor2+valor3;
	return retorno1;
}

int main() {
	setlocale (LC_ALL,"");
	string nombre;
	int resultado1, resultado2, valor1, valor2, valor3;
	cout << "Ingrese su nombre: " << endl;
	cin >> nombre;
	saludar(nombre);
	cout << "Ingrese tres números: " << endl;
	cin >> valor1 >> valor2 >> valor3;
	resultado1 = suma(valor1,valor2);
	resultado2 = suma1(valor1,valor2,valor3);
	cout << "El resultado de la suma de los dos primeros números es: " << resultado1 << endl;
	cout << "El resultado es de la suma de los tres números es: " << resultado2 << endl;
	return 0;
}

