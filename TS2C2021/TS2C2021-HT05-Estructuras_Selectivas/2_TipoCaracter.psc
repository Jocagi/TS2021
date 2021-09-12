Algoritmo TipoCaracter
	Definir X Como Caracter
	Leer X
	Si X >= "A" Y X <= "Z" 
	Entonces
		Escribir "Es mayúscula"
	SiNo
		Si X >= "0" Y X <= "9" 
		Entonces
			Escribir "Es número"
		SiNo
			Si X >= "a" Y X <= "z" 
				Entonces
				Escribir "Es minúscula"
				Escribir "Su correspondiente es: " MAYUSCULAS(X) 
			SiNo
				Escribir "Es otro"
			FinSi
		FinSi
	FinSi
FinAlgoritmo
