#include<stdio.h>

void saludar();
float calculardoble(float num);
void triplicar(float *num);

void saludar() {
	printf("Hola mundo!\n");
}

float calculardoble(float num) {
	float res;
	res = num*2;
	return res;
}

void triplicar(float *num) {
	(*num) = (*num)*3;
}

int main() {
	float x;
	printf("Llamada a la funcion Saludar:\n");
	saludar();
	printf("Ingrese un valor numérico para x:\n");
	scanf("%f",&x);
	printf("Llamada a la función CalcularDoble (pasaje por valor)\n");
	printf("El doble de %f es %s\n",x,calculardoble(x));
	printf("El valor original de x es %f\n",x);
	printf("Llamada a la función Triplicar (pasaje por referencia)\n");
	triplicar(&x);
	printf("El nuevo valor de x es %f\n",x);
	return 0;
}

