Algoritmo Fecha
	
	//Definici�n de variables
	Definir D Como Entero
	Definir M Como Entero
	Definir A Como Entero
	Definir Correcto Como L�gico
	
	//Lectura
	Escribir "Ingrese el d�a"
	Leer D
	Escribir "Ingrese el mes"
	Leer M
	Escribir "Ingrese el a�o"
	Leer A
	
	//Fecha ingresada
	Escribir "Has ingresado: ", D, "/", M, "/", A
	
	//Determinar si la fecha es correcta
	Correcto = Falso
	
	Si D >= 1 Y D <= 30 Entonces
		Escribir "El d�a ingresado es v�lido"
		Si M >= 1 Y M <= 12 Entonces
			Escribir "El mes ingresado es v�lido"
			Si A >= 1 Y M <= 2021 Entonces
				Escribir "El a�o ingresado es v�lido"
				Correcto = Verdadero
			SiNo
				Escribir "El a�o ingresado NO es v�lido"
			FinSi
		SiNo
			Escribir "El mes ingresado NO es v�lido"
		FinSi
	SiNo
		Escribir "El d�a ingresado NO es v�lido"
	FinSi
	
	//Si la fecha es correcta, calcular el d�a siguiente
	D = D + 1
	Si D > 30 Entonces
		D = 1
		M = M + 1
		Si M > 12 Entonces
			M = 1
			A = A + 1
		FinSi
	FinSi
	Escribir "D�a siguiente: ", D, "/", M, "/", A
	
FinAlgoritmo
