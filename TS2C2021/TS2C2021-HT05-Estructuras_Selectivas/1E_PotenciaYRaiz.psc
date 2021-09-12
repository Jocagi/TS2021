Algoritmo PotenciaYRaiz
	Definir X Como Entero
	Definir R Como Real
	Leer X
	Si (X MOD 5) == 0
	Entonces
		Escribir "Es múltiplo"	
		R = X ^ 2;
	SiNo
		Escribir "No es múltiplo"
		R = Raiz(X)
	FinSi
	Escribir "Resultado = " R
FinAlgoritmo
