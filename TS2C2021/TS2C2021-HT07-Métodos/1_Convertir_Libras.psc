Funcion res <- Lb_Kg(num) 
	res <- num * 0.453592
FinFuncion

Funcion res <- Lb_g(num) 
	res <- num * 453.592
FinFuncion

Funcion res <- Lb_Oz(num) 
	res <- num * 16
FinFuncion

Algoritmo Convertir_Libras
	
	Definir X Como Entero
	Escribir "Ingrese un número:"
	Leer X
	
	Escribir "Kilogramos: ", Lb_Kg(X)
	Escribir "Gramos: ", Lb_g(X)
	Escribir "Onzas: ", Lb_Oz(X)
	
FinAlgoritmo
