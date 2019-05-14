/* Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
Es posible que el codigo generado no sea completamente correcto. Si encuentra
errores por favor reportelos en el foro (http://pseint.sourceforge.net). */

#include<stdio.h>

int main() {
	int numero_1;
	int numero_2;
	printf("Ingrese el primer número\n");
	scanf("%i",&numero_1);
	printf("Ingrese el segundo numero\n");
	scanf("%i",&numero_2);
	if (numero_1<numero_2) {
		printf("%i es menor que %i\n",numero_1,numero_2);
	} else {
		if (numero_1==numero_2) {
			printf("%i es igual a %i\n",numero_1,numero_2);
		} else {
			printf("%i es mayor que %i\n",numero_1,numero_2);
		}
	}
	return 0;
}

