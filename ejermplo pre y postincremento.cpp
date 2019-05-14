#include <iostream>
using namespace std;

int main()
{
	int x;
	cout<<"Ingrese un valor"<<endl;
	cin>>x;
	if(x%2==0)
	{
		cout<<"El valor ingresado es par"<<endl;
	}
	else
	{
		cout<<"El valor ingresado es impar"<<endl;
	}
	
	
	//Con operador ternario
	
	(x%2==0) ? cout<<"El valor ingresado es par": cout<<"El valor ingresado es impar"<<endl;
	return 0;
}
