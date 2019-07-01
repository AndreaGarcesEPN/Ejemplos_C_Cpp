#include<iostream>
#include<stdio.h>
#include<cmath>
#include<cstdlib>
#include<ctime>
using namespace std;
struct circulo{
	int diametro;
	double area;
	int  radio;  //trabajar con estructura 
} circulo1={1}; ///el uno va al radio
double calcularArea(int radio);
void calculoArea(circulo &c);
void mostrarCirculo(circulo); //recibe una estructura por valor es un tipo de dato
circulo duplicarCirculo(circulo); //no muestra valores reales
int conteoCirculos(circulo[], int);
void llenarcirculosPares(circulo1[], circulo1[], int );
int main(){
	int arregCircuPares[];
	int tamArregloCirculos=5;
	circulo arr[tamArregloCirculos];
	srand(time(NULL));
	
	int radio;
	/*
 	cout<<"Radio: "<<circulo1.radio<<endl;
	cout<<"Diametro: "<<circulo1.diametro<<endl;
	cout<<"Area: "<<circulo1.area<<endl;   //se esta pasando por valor y no por referencia
	circulo1.area=calculoArea(circulo1);
	*/
	int valor;
	valor='x';
	//circulo=circuloGrande;
	
	/*duplicarCirculo(circulo1);
	mostrarCirculo(duplicarCirculo(circulo1));
	for(int i=0; i<tamArregloCirculos; i++){ //inicialuza radios.

	   circulos[i].radio=(1+rand()%15);
	   mostrarCirculo(circulos);
	   calculoArea(circulos[i]);
	   cout<<circulo();
	}
	*/
	cout<<"Circulo de radio par: "<<conteoCirculos(circulo)<<endl;
	

	return 0;
}
double calcularArea(int radio) { //recibe radio devuel area, y da valor del diametro
	double area=(3.1415)*radio*radio;
    return area;	
    circulo1.diametro;
}
void calculoArea(circulo &c){
	c.diametro=2*c.radio;
	c.area=(3.1415)*radio*radio;
	cout<<"En la funcion"<<c.diametro<<" "<<endl;
}
void mostrarCirculo(circulo){ //paso por valor   , calculos por referencia
}
circulo duplicarCirculo(circulo1){
	cout<<circulo;
	return circulo;
}  
int conteoCirculos(circulo[], int){
	cout<<circulos[];
	for(int i=0; i<tamArregloCirculos; i++){
		if(circulo.radio%2=0{
			if(circulo.radio){
				cout<<circulo<<endl;
			}  
		}
	}
}
void llenarcirculosPares(circulo1[], circulo1[], int ){
	int aux;
	
	for(int i=0; i<circulo arr[tamArregloCirculos]; i++){
		if(circulo arr[tamArregloCirculos]%2=0){
			circulo arr[tamArregloCirculos]=arregCircuPares[i];
			    
		}
	}
}

