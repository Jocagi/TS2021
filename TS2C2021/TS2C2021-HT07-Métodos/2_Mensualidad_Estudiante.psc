Funcion res <- Cuota(Saldo, Beca) 
	res <- (Saldo - (Saldo * Beca)) / 4  
FinFuncion

Funcion res <- ConvertirAPorcentaje(num) 
	res <- num / 100  
FinFuncion

Algoritmo Mensualidad_Estudiante
	
	Definir nombre, carnet, beca Como Caracter
	Definir saldo, porcentaje, mensualidad Como Real
	
	Escribir "Ingrese su nombre: "
	Leer nombre
	Escribir "Ingrese su carnet: "
	Leer carnet
	Escribir "Ingrese su saldo: "
	Leer saldo
	Escribir "¿Tiene beca? (s/n)"
	Leer beca
	
	Si (beca == "s" O beca == "S")
		Escribir "Ingrese % de beca: "
		Leer porcentaje
		porcentaje = ConvertirAPorcentaje(porcentaje)
	SiNo
		porcentaje = 0
	FinSi
	
	mensualidad = Cuota(saldo, porcentaje)
	
	Escribir "Estimado ", nombre, " su cuota mensual es de: ", mensualidad
	
FinAlgoritmo
