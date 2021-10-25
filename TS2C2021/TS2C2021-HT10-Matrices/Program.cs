using System;

namespace TS2C2021_HT10_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool salir = false;
            int opcion = 0;

            while (!salir)
            {
                Console.WriteLine("");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Ingrese el numero de ejercicio:");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Salir");

                try
                {
                    opcion = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                switch (opcion)
                {
                    case 1:
                        ejercicio1();
                        break;
                    case 2:
                        ejercicio2();
                        break;
                    case 3:
                        ejercicio3();
                        break;
                    case 4:
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        salir = true;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ejercicio1()
        {
            Console.WriteLine("\nEjercicio 1: ");

            Console.WriteLine("\nArreglo de 52 numeros: ");
            int[] array = RandomIntArray(52, 0, 100);
            WriteArray(array);

            try
            {
                Console.Write("\nIngrese la cantidad de numeros a ignorar: ");
                int CANTIDAD_NUM = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nResultado: ");
                for (int i = CANTIDAD_NUM; i < 52; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void ejercicio2()
        {
            Console.WriteLine("\nEjercicio 2: ");

            try
            {
                Console.Write("\nIngrese la cantidad de filas de la matriz 1: ");
                int X_M2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese la cantidad de columnas de la matriz 1: ");
                int Y_M2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n\nIngrese la cantidad de filas de la matriz 2: ");
                int X_M1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese la cantidad de columnas de la matriz 2: ");
                int Y_M1 = Convert.ToInt32(Console.ReadLine());

                if (X_M1 >= 1 && Y_M1 >= 1 && X_M2 >= 1 && Y_M2 >= 1 && (Y_M1 == X_M2))
                {
                    Console.WriteLine("\nMatriz 1: ");
                    int[,] MATRIZ1 = RandomIntMatrix(X_M1, Y_M1, 0, 10);
                    WriteMatrix(MATRIZ1);

                    Console.WriteLine("\nMatriz 2: ");
                    int[,] MATRIZ2 = RandomIntMatrix(X_M2, Y_M2, 0, 10);
                    WriteMatrix(MATRIZ2);

                    int[,] RESULTADO = new int[X_M1, Y_M2];

                    for (int i = 0; i < X_M1; i++)
                    {
                        for (int j = 0; j < Y_M2; j++)
                        {
                            for (int k = 0; k < Y_M1; k++)
                            {
                                RESULTADO[i, j] += MATRIZ1[i, k] * MATRIZ2[k, j];
                            }
                        }
                    }

                    Console.WriteLine("\nResultado: ");
                    WriteMatrix(RESULTADO);
                }
                else
                {
                    Console.WriteLine("Una de las dimensiones ingresadas no es correcta");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void ejercicio3()
        {
            string opcion;

            try
            {
                int[,] MATRIZ1 = RandomIntMatrix(5, 4, 0, 10);
                int[,] MATRIZ2 = RandomIntMatrix(5, 4, 0, 10);

                Console.WriteLine("\nEjercicio 3: ");
                Console.WriteLine("Ingrese la letra del inciso:");
                Console.WriteLine("a. Comparativa de matrices");
                Console.WriteLine("b. Matriz transpuesta");
                Console.WriteLine("c. Posiciones de un elemento");
                Console.WriteLine("d. Vector no repetidos");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "a":
                        //Comparativa de matrices
                        Console.WriteLine("Comparativa de matrices");
                        Console.WriteLine("\nMatriz 1: ");
                        WriteMatrix(MATRIZ1);
                        Console.WriteLine("\nMatriz 2: ");
                        WriteMatrix(MATRIZ2);
                        int resultadoA = cantidadElementosIguales(MATRIZ1, MATRIZ2);
                        Console.WriteLine("La cantidad de elementos iguales es: " + resultadoA);
                        break;
                    case "b":
                        //Matriz transpuesta
                        Console.WriteLine("Matriz transpuesta");
                        Console.WriteLine("\nMatriz: ");
                        WriteMatrix(MATRIZ1);
                        int[,] resultadoB = matrizTranspuesta(MATRIZ1);
                        Console.WriteLine("Resultado:");
                        WriteMatrix(resultadoB);
                        break;
                    case "c":
                        //Posiciones de un elemento
                        int busqueda = 0;
                        Console.WriteLine("Todas las posiciones de un elemento a buscar");
                        Console.WriteLine("\nMatriz: ");
                        WriteMatrix(MATRIZ1);
                        Console.Write("\nIngrese el valor a buscar:");
                        busqueda = Convert.ToInt32(Console.ReadLine());
                        int[,] resultadoC = buscarValor(MATRIZ1, busqueda);
                        Console.WriteLine("Resultado:");
                        WriteMatrix(resultadoC);
                        break;
                    case "d":
                        //Vector no repetidos
                        Console.WriteLine("Valores no repetidos en matriz");
                        Console.WriteLine("\nMatriz: ");
                        WriteMatrix(MATRIZ1);
                        int[] resultadoD = valoresRepetidos(MATRIZ1);
                        Console.WriteLine("Resultado:");
                        WriteDistincElementsArray(resultadoD);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static int cantidadElementosIguales(int[,] matriz1, int[,] matriz2) 
        {
            int counter = 0;

            int rows1 = matriz1.GetLength(0);
            int columns1 = matriz1.GetLength(1);

            int rows2 = matriz2.GetLength(0);
            int columns2 = matriz2.GetLength(1);

            if (rows1 == rows2 && columns1 == columns2)
            {
                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < columns1; j++)
                    {
                        if (matriz1[i, j] == matriz2[i, j]) 
                        {
                            counter++;
                        }
                    }
                }
                return counter;
            }
            else
            {
                throw new Exception("La longitud de las matrices no coincide");
            }
        }

        static int[,] matrizTranspuesta(int[,] matriz)
        {
            int rows = matriz.GetLength(0);
            int columns = matriz.GetLength(1);
            int[,] resultado = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultado[j, i] = matriz[i, j];
                }
            }

            return resultado;
        }

        static int[,] buscarValor(int[,] matriz, int valor)
        {
            int rows = matriz.GetLength(0);
            int columns = matriz.GetLength(1);

            int[,] resultado = new int[rows * columns, 2];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        resultado[index, 0] = i;
                        resultado[index, 1] = j;
                        index++;
                    }
                }
            }

            int[,] resultadoFinal = new int[index, 2];
            for (int k = 0; k < index; k++)
            {
                resultadoFinal[k, 0] = resultado[k, 0];
                resultadoFinal[k, 1] = resultado[k, 1];
            }
            return resultadoFinal;
        }

        static int[] valoresRepetidos(int[,] matriz)
        {
            int rows = matriz.GetLength(0);
            int columns = matriz.GetLength(1);

            int[] resultado = new int[rows * columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //Busqueda repetidos
                    for (int n = 0; n < rows; n++)
                    {
                        for (int m = 0; m < columns; m++)
                        {
                            if (matriz[i, j] == matriz[n, m] && !(i == n && j == m))
                            {
                                goto FinBusqueda;
                            }
                        }
                    }
                    resultado[index] = matriz[i, j];
                    index++;
                    FinBusqueda:;
                }
            }

            int[] resultadoFinal = new int[index];
            for (int k = 0; k < index; k++)
            {
                resultadoFinal[k] = resultado[k];
            }
            return resultadoFinal;
        }

        static void WriteArray<T>(T[] array)
        {
            if (array.Length > 0)
            {
                Console.WriteLine("[{0}]", string.Join(", ", array));
            }
            else 
            {
                Console.WriteLine("No hay elementos");
            }
        }

        static void WriteDistincElementsArray<T>(T[] array)
        {
            if (array.Length > 0)
            {
                Console.Write("[{0}", array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    bool different = true;

                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (array[i].Equals(array[j]))
                        {
                            different = false;
                            break;
                        }
                    }

                    if (different)
                    {
                        Console.Write(", " + array[i]);
                    }
                }
                Console.Write("]");
            }
            else
            {
                Console.WriteLine("No hay elementos");
            }
        }

        static void WriteMatrix<T>(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        static int[] RandomIntArray(int length, int min, int max)
        {
            Random rand = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                int value = rand.Next(min, max);
                array[i] = value;
            }

            return array;
        }

        static int[,] RandomIntMatrix(int n, int m, int min, int max)
        {
            Random rand = new Random();
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int value = rand.Next(min, max);
                    matrix[i, j] = value;
                }
            }

            return matrix;
        }
    }
}
