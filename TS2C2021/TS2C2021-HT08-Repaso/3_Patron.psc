Algoritmo Patron
		Definir X Como Entero
		
		Escribir "Ingrese un n�mero"
		Leer X
		
		Si X >= 1 Y X <= 15 Entonces
			Para i Desde X Hasta 1 Con Paso -1 Hacer
				Para j Desde 1 Hasta i Hacer
					Escribir Sin Saltar "*"
				FinPara
				Escribir ""
			FinPara
		SiNo
			Escribir "No est� en el rango permitido"
		FinSi
FinAlgoritmo