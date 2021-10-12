Funcion res <- ConvertirABinario(decimal) 
	Definir x, residuo Como Entero
	Definir binario Como Caracter
	
	x = decimal
	
	Mientras x <> -1
		residuo = x MOD 2
		x = TRUNC(x / 2)
		
		binario = Concatenar(ConvertirATexto(residuo), binario)
		
		Si x == 1 O x == 0
			binario = Concatenar(ConvertirATexto(x), binario)
			x = -1
		FinSi
		
	FinMientras
	
	res <- binario  
FinFuncion

Algoritmo DecimalBinario
	
	Definir decimal Como Entero 
	Definir binario Como Caracter
	
	Escribir "Ingrese el número a convertir: "
	Leer decimal
	
	binario = ConvertirABinario(decimal)
	
	Escribir "El número ", decimal, " en binario es ", binario
	
FinAlgoritmo
