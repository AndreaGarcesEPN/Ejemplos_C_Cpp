Funcion saludar (valor)
	Escribir "Hola ",valor;
Fin Funcion


Funcion retorno <- suma (valor1, valor2)
	Definir retorno Como Entero;
	retorno = valor1 + valor2;
Fin Funcion


Funcion retorno1 <- suma1 ( valor1, valor2, valor3 )
	Definir retorno1 Como Entero;
	retorno1 = valor1 + valor2 + valor3;
Fin Funcion


Algoritmo Suma_dos_numeros
	Definir valor1, valor2, valor3, resultado1, resultado2 como entero;
	Definir nombre como cadena;
	Escribir "Ingrese su nombre: ";
	Leer nombre;
	saludar(nombre);
	Escribir "Ingrese tres números: ";
	Leer valor1, valor2, valor3;
	resultado1 = suma (valor1, valor2);
	resultado2 = suma1 (valor1, valor2, valor3);
	Escribir "El resultado de la suma de los dos primeros números es: ",resultado1;
	Escribir "El resultado es de la suma de los tres números es: ",resultado2;
FinAlgoritmo
