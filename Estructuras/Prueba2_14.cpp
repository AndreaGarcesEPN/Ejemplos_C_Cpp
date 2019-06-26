#include<iostream>

using namespace std;

int main()
{
	char cadena[40];
	int contador_min = 0;
	int contador_mayus = 0;
	int contador_esp = 0;
	cout << "Ingrese una frase de máximo 40 caracteres: ";
	for(int x = 0; x < 40; x++)
	{
		cin >> cadena[x];	
	}
	for(int i = 0; i < 40; i++)
    {
        if('A' >= cadena[i] && cadena[i] <= 'Z') 
        { 
            contador_mayus ++; 
        }
        if('a' >= cadena[i] && cadena[i] <= 'z')
        {
        	contador_min ++;
		}
		if(cadena[i] == ' ')
		{
			contador_esp ++;
			
		}
    }
    cout << "El numero de mayusculas es: " << contador_mayus << endl;
    cout << "El numero de minusculas es: " << contador_min << endl;
	cout << "El numero de espacios es: " << contador_esp << endl; 
	return 0;
}
