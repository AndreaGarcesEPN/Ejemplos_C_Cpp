Algoritmo Ejemplo_Si_Entonces
	Definir numero_1,numero_2 Como Entero;
	Escribir 'Ingrese el primer número';
	Leer numero_1;
	Escribir 'Ingrese el segundo numero';
	Leer numero_2;
	Si numero_1<numero_2 Entonces
		Escribir numero_1,' es menor que ',numero_2;
	SiNo
		Si numero_1 = numero_2 entonces
			Escribir numero_1," es igual a ",numero_2;
		SiNo
			Escribir numero_1,' es mayor que ',numero_2;
		FinSi
	FinSi
FinAlgoritmo

