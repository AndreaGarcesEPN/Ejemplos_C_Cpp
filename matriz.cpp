#include <iostream>
using namespace std;

char matriz[8][8];

void llenar_matriz()
{
	for(int i=0; i<8; i++)
	{
		for(int j=0; j<8; j++)
		{
			if(i%2 == 0)
			{
				if(j%2 == 0)
				{
					matriz[i][j]='*';
				}
				else
				{
					matriz[i][j]='-';
				}
			}
			else
			{
				if(j%2 == 0)
				{
					matriz[i][j]='-';
				}
				else
				{
					matriz[i][j]='*';
				}
			}
		}
	}
}

void imprimir_matriz()
{
	for(int i=0; i<8; i++)
	{
		for(int j=0; j<8; j++)
		{
			cout << matriz[i][j];
		}
		cout << endl;
	}
}

int main()
{
	llenar_matriz();
	imprimir_matriz();
	return 0;
}
