Algoritmo TipoCaracter
	Definir X Como Caracter
	Leer X
	Si X >= "A" Y X <= "Z" 
	Entonces
		Escribir "Es may�scula"
	SiNo
		Si X >= "0" Y X <= "9" 
		Entonces
			Escribir "Es n�mero"
		SiNo
			Si X >= "a" Y X <= "z" 
				Entonces
				Escribir "Es min�scula"
				Escribir "Su correspondiente es: " MAYUSCULAS(X) 
			SiNo
				Escribir "Es otro"
			FinSi
		FinSi
	FinSi
FinAlgoritmo
