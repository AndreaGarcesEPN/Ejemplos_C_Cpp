// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

#include<iostream>
#include<cstdlib>
using namespace std;

// Para leer variables de texto se utiliza el operador << del objeto cin, que
// lee solo una palabra. Para leer una linea completa (es decir, incluyendo los
// espacios en blanco) se debe utilzar getline (ej, reemplazar cin>>x por
// getline(cin,x)), pero obliga a agregar un cin.ignore() si antes del getline
// se leyó otra variable con >>.

// Juego simple que pide al usuario que adivine un numero en 10 intentos
int main() {
	int intentos;
	int num_ingresado;
	int num_secreto;
	intentos = 10;
	num_secreto = (rand()%100)+1;
	cout << "Adivine el numero (de 1 a 100):" << endl;
	cin >> num_ingresado;
	while (num_secreto!=num_ingresado & intentos>1) {
		if (num_secreto>num_ingresado) {
			cout << "Muy bajo" << endl;
		} else {
			cout << "Muy alto" << endl;
		}
		intentos = intentos-1;
		cout << "Le quedan " << intentos << " intentos:" << endl;
		cin >> num_ingresado;
	}
	if (num_secreto==num_ingresado) {
		cout << "Exacto! Usted adivino en " << 11-intentos << " intentos." << endl;
	} else {
		cout << "El numero era: " << num_secreto << endl;
	}
	return 0;
}

