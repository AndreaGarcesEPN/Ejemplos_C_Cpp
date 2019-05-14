#include<iostream>
#include <iomanip>
using namespace std;

int main() 
{
	int a;
	int i;
	cout << "Ingrese un numero a multiplicar" << endl;
	cin >> a;
	for (i=1;i<=12;i++) 
	{
		cout << setw(3) << a << setw(3) << "x" << i << "=" << setw(5) << a*i << endl;
	}
	return 0;
}
