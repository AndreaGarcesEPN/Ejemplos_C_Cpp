#include<iostream>

using namespace std;

double MaximoValor(double matriz[3][3])
{
	double maximo_fila0, maximo_fila1, maximo_fila2;
	for(int i = 0; i < 3; i++)
	{
		if(matriz[0][i] > matriz[1][i] && matriz[0][i] > matriz[2][i])
		{
			maximo_fila0 = matriz[0][i];
		}
		else
		{
			if(matriz[1][i] > matriz[0][i] && matriz [1][i] > matriz[2][i])
			{
				maximo_fila0 = matriz[1][i];
			}
			else
			{
				if(matriz[2][i] > matriz[0][i] && matriz [2][i] > matriz[1][i])
				{
					maximo_fila0 = matriz[2][i];
				}
			}
		}
	}
	return maximo_fila0;
}

int main()
{
	double matriz[3][3] = {2.9, 5.6, 7.98, 3.7, 1.5, 4.2, 8.2, 9.8, 6.45};
	cout << "El valor maximo de la primera fila es: " << MaximoValor(matriz);
	return 0;
}
