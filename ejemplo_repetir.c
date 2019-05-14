/* Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
Es posible que el codigo generado no sea completamente correcto. Si encuentra
errores por favor reportelos en el foro (http://pseint.sourceforge.net). */

#include<stdio.h>

/* Muestra como hacer un menú simple con las estructuras Repetir-Hasta Que y Según */
int main() {
	int op;
	do {
		/* mostrar menu */
		printf("\n"); /* no hay forma directa de borrar la pantalla con C estandar */
		printf("Menú de recomendaciones\n");
		printf("   1. Literatura\n");
		printf("   2. Cine\n");
		printf("   3. Música\n");
		printf("   4. Videojuegos\n");
		printf("   5. Salir\n");
		/* ingresar una opcion */
		printf("Elija una opción (1-5): \n");
		scanf("%i",&op);
		/* procesar esa opción */
		switch (op) {
		case 1:
			printf("Lecturas recomendables:\n");
			printf(" + Esperándolo a Tito y otros cuentos de fúbol (Eduardo Sacheri)\n");
			printf(" + El juego de Ender (Orson Scott Card)\n");
			printf(" + El sueño de los héroes (Adolfo Bioy Casares)\n");
			break;
		case 2:
			printf("Películas recomendables:\n");
			printf(" + Matrix (1999)\n");
			printf(" + El último samuray (2003)\n");
			printf(" + Cars (2006)\n");
			break;
		case 3:
			printf("Discos recomendables:\n");
			printf(" + Despedazado por mil partes (La Renga, 1996)\n");
			printf(" + Búfalo (La Mississippi, 2008)\n");
			printf(" + Gaia (Mägo de Oz, 2003)\n");
			break;
		case 4:
			printf("Videojuegos clásicos recomendables\n");
			printf(" + Día del tentáculo (LucasArts, 1993)\n");
			printf(" + Terminal Velocity (Terminal Reality/3D Realms, 1995)\n");
			printf(" + Death Rally (Remedy/Apogee, 1996)\n");
			break;
		case 5:
			printf("Gracias, vuelva pronto\n");
			break;
		default:
			printf("Opción no válida\n");
		}
		printf("Presione enter para continuar\n");
		getchar(); /* a diferencia del pseudocódigo, espera un Enter, no cualquier tecla */
	} while (op!=5);
	return 0;
}

