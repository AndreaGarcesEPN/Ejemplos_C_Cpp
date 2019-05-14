#include <iostream>
#include <conio.h>
using namespace std;

//Algoritmo que sume los 30 primeros número excepto los múltiplos de 5

int main(int argc, char** argv) 
{
	int acumulador = 0;
	cout<<"Programa que sume los 30 primeros números"<<endl;
	for(int i=0;i<30;i++)
	{
		acumulador += i;
		if(i%15==0)
		{
			return 0;
		}
		
	}
	cout<<"El valor acumulado es: "<<acumulador;
	getch();
	return 0;
}

