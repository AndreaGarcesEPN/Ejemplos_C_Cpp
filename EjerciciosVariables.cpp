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
	string anio;
	string anio2;
	int anio3[4];
	string fal;
	int numero1;
	string numero2;
	int numneg;
	float numpi;
	string text;
	bool verd;
	numero1 = 5;
	numero2 = "5";
	text = "5";
	numneg = -4;
	numpi = 3.14;
	anio = "2019";
	anio2 = "2019";
	verd = true;
	fal = "Falso";
	anio3[0] = 2;
	anio3[1] = 0;
	anio3[2] = 1;
	anio3[3] = 9;
	cout << numero1 << endl;
	cout << numero2 << endl;
	cout << text << endl;
	cout << numneg << endl;
	cout << numpi << endl;
	cout << anio << endl;
	cout << anio2 << endl;
	cout << verd << endl;
	cout << fal << endl;
	cout << anio3[0] << anio3[1] << anio3[2] << anio3[3] << endl;
	return 0;
}

