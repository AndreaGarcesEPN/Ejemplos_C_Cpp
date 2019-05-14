/* Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
Es posible que el codigo generado no sea completamente correcto. Si encuentra
errores por favor reportelos en el foro (http://pseint.sourceforge.net). */

#include<stdio.h>
#include<stdbool.h>

/* En C no hay variables para guardar cadenas de texto, sino que debe construirse
   un arreglo de caracteres (tipo char). El tamaño del arreglo determina la longitud
   máxima que puede tener la cadena que guarda (tamaño-1, por el caracter de terminación).
   La constante MAX_STRLEN define el tamaño máximo que se utiliza en este programa para
   cualquier cadena. */
#define MAX_STRLEN 256

int main() {
	char anio[MAX_STRLEN];
	char anio2[MAX_STRLEN];
	int anio3[4];
	char fal[MAX_STRLEN];
	int numero1;
	char numero2[MAX_STRLEN];
	int numneg;
	float numpi;
	char text[MAX_STRLEN];
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
	printf("%i\n",numero1);
	printf("%s\n",numero2);
	printf("%s\n",text);
	printf("%i\n",numneg);
	printf("%f\n",numpi);
	printf("%s\n",anio);
	printf("%s\n",anio2);
	printf("%i\n",verd);
	printf("%s\n",fal);
	printf("%i%i%i%i\n",anio3[0],anio3[1],anio3[2],anio3[3]);
	return 0;
}

