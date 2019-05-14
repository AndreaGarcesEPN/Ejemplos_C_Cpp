#include <iostream>
using namespace std;

int main()
{
	int valor_1, valor_2, valor_3;
	float solucion;
	int operacion;
	
	cout << "Seleccione la operación que desea realizar" << endl;
	cout << "1 : Suma" << endl; 
	cout << "2 : Promedio" << endl;
	cout << "3 : Producto" << endl;
	cout << "4 : Menor o mayor" << endl;
	cout << "S : Finalizar" << endl;
	
	
	cin >> operacion;
	do
	{

	switch (operacion)
	{
		case 1:
			cout << "Ingrese tres números" << endl;
			cin >> valor_1; 
			cin >> valor_2; 
			cin >> valor_3;
			solucion = valor_1 + valor_2 + valor_3;
			cout << "La solución es: "<< solucion << endl;
			break;
		case 2:	
			cout << "Ingrese tres números" << endl;
			cin >> valor_1; 
			cin >> valor_2; 
			cin >> valor_3;
			solucion = (valor_1 + valor_2 + valor_3)/3;
			cout << "La solución es: " << solucion << endl;
			break;
		case 3:
			cout << "Ingrese tres números" << endl;
			cin >> valor_1; 
			cin >> valor_2; 
			cin >> valor_3;
			solucion = valor_1 * valor_2 * valor_3;
			cout << "La solución es: "<< solucion << endl;
			break;
		case 4: 
			cout << "Ingrese tres números" << endl;
			cin >> valor_1; 
			cin >> valor_2; 
			cin >> valor_3;
			
			if(valor_1>valor_2)
			{
				if(valor_1>valor_3)
				{
					cout << "El mayor es: " << valor_1 << endl;
				}
				else
				{
					cout << "El mayor es: " << valor_3 << endl;
				}
			}
			else
			{
				if(valor_2>valor_3)
				{
					cout << "El mayor es: " << valor_2 << endl;
				}
				else
				{
					cout << "El mayor es: " << valor_3 << endl;
				}
			}
			
			if(valor_1<valor_2)
			{
				if(valor_1<valor_3)
				{
					cout << "El menor es: " << valor_1 << endl;
				}
				else
				{
					cout << "El menor es: " << valor_3 << endl;
				}
			}
			else
			{
				if(valor_2<valor_3)
				{
					cout << "El menor es: " << valor_2 << endl;
				}
				else
				{
					cout << "El menor es: " << valor_3 << endl;
				}
			}
			
			break;
		case 's':
			cout << "Usted ha salido" << endl;
			break;
	}
	} while (operacion > 5);
}
