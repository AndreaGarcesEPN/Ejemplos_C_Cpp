// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

#include<iostream>
#include<cmath>
using namespace std;

// Para leer variables de texto se utiliza el operador << del objeto cin, que
// lee solo una palabra. Para leer una linea completa (es decir, incluyendo los
// espacios en blanco) se debe utilzar getline (ej, reemplazar cin>>x por
// getline(cin,x)), pero obliga a agregar un cin.ignore() si antes del getline
// se ley� otra variable con >>.

// Declaraciones adelantadas de las funciones
float suma(float valor);

float suma(float valor) {
	float x;
	x = sqrtf(valor)+1;
	return x;
}

int main() {
	int valor;
	cin >> valor;
	cout << suma(valor) << endl;
	return 0;
}

