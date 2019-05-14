/* Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
Es posible que el codigo generado no sea completamente correcto. Si encuentra
errores por favor reportelos en el foro (http://pseint.sourceforge.net). */

#include<stdio.h>

/* En C no hay variables para guardar cadenas de texto, sino que debe construirse
   un arreglo de caracteres (tipo char). El tamaño del arreglo determina la longitud
   máxima que puede tener la cadena que guarda (tamaño-1, por el caracter de terminación).
   La constante MAX_STRLEN define el tamaño máximo que se utiliza en este programa para
   cualquier cadena. */
#define MAX_STRLEN 256

/* Para las variables que no se pudo determinar el tipo se utiliza la constante
   SIN_TIPO. El usuario debe reemplazar sus ocurrencias por el tipo adecuado
   (usualmente int,float,bool, o char[]). */
#define SIN_TIPO float

/* Para leer variables de texto se utiliza scanf, que lee solo una palabra. 
   Para leer una linea completa (es decir, incluyendo los espacios en blanco)
   se debe utilzar ges (ej, reemplazar scanf("%s",x) por gets(x)) pero 
   obliga a agregar un getchar() antes del gets si antes del mismo se leyó
   otra variable con scanf. */

// Declaraciones adelantadas de las funciones
void saludar(SIN_TIPO valor);
int suma(SIN_TIPO valor1, SIN_TIPO valor2);
int suma1(SIN_TIPO valor1, SIN_TIPO valor2, SIN_TIPO valor3);

void saludar(SIN_TIPO valor) {
	printf("Hola %s\n",valor);
}

int suma(SIN_TIPO valor1, SIN_TIPO valor2) {
	int retorno;
	retorno = valor1+valor2;
	return retorno;
}

int suma1(SIN_TIPO valor1, SIN_TIPO valor2, SIN_TIPO valor3) {
	int retorno1;
	retorno1 = valor1+valor2+valor3;
	return retorno1;
}

int main() {
	char nombre[MAX_STRLEN];
	int resultado1;
	int resultado2;
	int valor1;
	int valor2;
	int valor3;
	printf("Ingrese su nombre: \n");
	scanf("%s",nombre);
	saludar(nombre);
	printf("Ingrese tres números: \n");
	scanf("%i",&valor1);
	scanf("%i",&valor2);
	scanf("%i",&valor3);
	resultado1 = suma(valor1,valor2);
	resultado2 = suma1(valor1,valor2,valor3);
	printf("El resultado de la suma de los dos primeros números es: %i\n",resultado1);
	printf("El resultado es de la suma de los tres números es: %i\n",resultado2);
	return 0;
}

