#include <iostream>
using namespace std;

int main()
{
	int acum=0;
	for(int i=0;i<30;i++)
	{
		if (i%5==0)
		{
			continue;//saltar
		}
		acum += i;//acum = acum + i
	}
	cout << "La suma es: " << acum; 
}


