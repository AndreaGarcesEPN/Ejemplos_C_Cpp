#include <stdio.h>
#include <ctype.h>
#include <stdlib.h>

main()
{
	char letra = '/0';
	for(;toupper(letra) != 'A';)
	{
		printf("\nIngrese la letra A: ");
		scanf("%c",&letra);
		system("cls");	
	}
	return 0;
}
