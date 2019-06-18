#include <iostream>

using namespace std;

//Ejemplo de función iterativa
void FibonacciIterativa(int n)
{
	int x, y, result;
	for(x = 1; x < (n - 2); x++)
	{
		result = x + y;
		y = x;
		x = result;
	}
}

//Ejemplo de función recursiva
int Fibonacci(int n)
{
	if(n < 2)
	{
		return n;
	}
	else
	{
		return (Fibonacci (n - 2) + Fibonacci (n - 1));
	}
}

int main()
{
	int n, result;
	cout << "---Serie de Fibonacci---" << endl;
	cout << "Ingrese un valor: ";
	cin >> n;
	result = Fibonacci(n);
	cout << "El resultado es: " << result << endl;
	return 0;
}
