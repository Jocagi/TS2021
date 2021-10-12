Algoritmo Fecha
	
	//Definición de variables
	Definir D Como Entero
	Definir M Como Entero
	Definir A Como Entero
	Definir Correcto Como Lógico
	
	//Lectura
	Escribir "Ingrese el día"
	Leer D
	Escribir "Ingrese el mes"
	Leer M
	Escribir "Ingrese el año"
	Leer A
	
	//Fecha ingresada
	Escribir "Has ingresado: ", D, "/", M, "/", A
	
	//Determinar si la fecha es correcta
	Correcto = Falso
	
	Si D >= 1 Y D <= 30 Entonces
		Escribir "El día ingresado es válido"
		Si M >= 1 Y M <= 12 Entonces
			Escribir "El mes ingresado es válido"
			Si A >= 1 Y M <= 2021 Entonces
				Escribir "El año ingresado es válido"
				Correcto = Verdadero
			SiNo
				Escribir "El año ingresado NO es válido"
			FinSi
		SiNo
			Escribir "El mes ingresado NO es válido"
		FinSi
	SiNo
		Escribir "El día ingresado NO es válido"
	FinSi
	
	//Si la fecha es correcta, calcular el día siguiente
	D = D + 1
	Si D > 30 Entonces
		D = 1
		M = M + 1
		Si M > 12 Entonces
			M = 1
			A = A + 1
		FinSi
	FinSi
	Escribir "Día siguiente: ", D, "/", M, "/", A
	
FinAlgoritmo
