#include<iostream> 

using namespace std; 

int main() 

{ 
    string cadena = "Escuela Polit�cnica Nacional";//13 vocales 
    int contador = 0; 
    for(int i = 0; i < 28; i++) 
    {
        if(cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i'  
        || cadena[i] == 'o' || cadena[i] == 'u' || cadena[i] == 'a' 
        || cadena[i] == 'E' || cadena[i] == '�') 
        { 
            contador ++; 
        } 
    } 

    cout << "El n�mero de vocales es: " << contador; 

    return 0; 

} 
