#include<iostream>

using namespace std;

double MaximoValor(double matriz[3][3])
{
	double maximo;
	for(int i = 0; i < 3; i++)
	{
		for(int j = 0; j < 3; j++)
		{
			if(matriz[i])
		}
	}
	return maximo;
}

int main()
{
	double matriz[3][3] = {2.9, 5.6, 7.98, 3.7, 1.5, 4.2, 8.2, 9.8, 6.45};
	cout << "El valor maximo de la primera fila es: " << MaximoValor(matriz);
	return 0;
}
