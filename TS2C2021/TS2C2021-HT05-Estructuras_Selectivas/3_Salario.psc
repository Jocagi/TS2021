Algoritmo Salario
	Definir Nombre Como Caracter
	Definir Cargo Como Caracter
	Definir Monto Como Caracter
	Definir X Como Entero
	Escribir "Ingrese su nombre"
	Leer Nombre
	Escribir "Ingrese su cargo"
	Leer Cargo
	Escribir "Ingrese tiempo de servicio"
	Leer X
	Si X >= 0 Y X <= 2 
	Entonces
		Monto = "Q2000.00"
	SiNo
		Si X >= 3 Y X <= 5 
		Entonces
			Monto = "Q2500.00"
		SiNo
			Si X >= 6 Y X <= 8 
			Entonces
			Monto = "Q3000.00" 
			SiNo
				Si X >= 8 
					Entonces
					Monto = "Q4000.00" 
				SiNo
					Escribir "Inválido"
				FinSi
			FinSi
		FinSi
	FinSi
	
	Si Monto <> "" Entonces
		Escribir "Estimado " Nombre " con cargo " Cargo " su salario es " Monto
	Fin Si
	
FinAlgoritmo
