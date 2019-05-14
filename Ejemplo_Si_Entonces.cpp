// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

#include<iostream>
using namespace std;

// Para leer variables de texto se utiliza el operador << del objeto cin, que
// lee solo una palabra. Para leer una linea completa (es decir, incluyendo los
// espacios en blanco) se debe utilzar getline (ej, reemplazar cin>>x por
// getline(cin,x)), pero obliga a agregar un cin.ignore() si antes del getline
// se leyó otra variable con >>.

int main() {
	int numero_1;
	int numero_2;
	cout << "Ingrese el primer número" << endl;
	cin >> numero_1;
	cout << "Ingrese el segundo numero" << endl;
	cin >> numero_2;
	if (numero_1<numero_2) {
		cout << numero_1 << " es menor que " << numero_2 << endl;
	} else {
		if (numero_1==numero_2) {
			cout << numero_1 << " es igual a " << numero_2 << endl;
		} else {
			cout << numero_1 << " es mayor que " << numero_2 << endl;
		}
	}
	return 0;
}

