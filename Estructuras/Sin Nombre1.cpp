#include <stdio.h>
#include <time.h>
 
int main( void )
{
   long int i=0;
   clock_t comienzo;
  float ala;
   comienzo=clock();
   for( i=0; i<10000; i++ )   printf( "-" );
  ala =(clock()-comienzo)/(double)CLOCKS_PER_SEC;
   printf( "N&uacute;mero de segundos transcurridos desde el comienzo del programa: %f s\n", ala );
 
   return 0;
}
