/* Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
Es posible que el codigo generado no sea completamente correcto. Si encuentra
errores por favor reportelos en el foro (http://pseint.sourceforge.net). */

#include<stdio.h>
#include<stdlib.h>

/* Juego simple que pide al usuario que adivine un numero en 10 intentos */
int main() {
	int intentos;
	int num_ingresado;
	int num_secreto;
	intentos = 10;
	num_secreto = (rand()%100)+1;
	printf("Adivine el numero (de 1 a 100):\n");
	scanf("%i",&num_ingresado);
	while (num_secreto!=num_ingresado && intentos>1) {
		if (num_secreto>num_ingresado) {
			printf("Muy bajo\n");
		} else {
			printf("Muy alto\n");
		}
		intentos = intentos-1;
		printf("Le quedan %i intentos:\n",intentos);
		scanf("%i",&num_ingresado);
	}
	if (num_secreto==num_ingresado) {
		printf("Exacto! Usted adivino en %f intentos.\n",11-intentos);
	} else {
		printf("El numero era: %i\n",num_secreto);
	}
	return 0;
}

