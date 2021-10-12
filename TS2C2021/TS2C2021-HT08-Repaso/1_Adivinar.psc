Algoritmo Adivinar
	Definir N Como Entero
	Definir X Como Entero

	N = Aleatorio(0, 100)
	
	Mientras N <> X Hacer
		Escribir "Ingrese un número"
		Leer X
		Si X > N Entonces
			Escribir "Mayor"
		SiNo
			Si X < N Entonces
				Escribir "Menor"
			SiNo
				Escribir "Has acertado!"
			FinSi
		FinSi
	FinMientras
FinAlgoritmo
