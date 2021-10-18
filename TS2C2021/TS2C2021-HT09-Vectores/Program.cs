using System;

namespace TS2C2021_HT09_Vectores
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
                Console.WriteLine("1. Ej1-Datos");
                Console.WriteLine("2. Ej2-Promedio");
                Console.WriteLine("3. Ej3-Valor a pagar");
                Console.WriteLine("4. Ej4-Intercambio");
                Console.WriteLine("5. Salir");

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
                        ejercicio4();
                        break;
                    case 5:
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

            int[] valores = { 85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93 };

            //Mostrar al usuario el array
            Console.WriteLine("\nValores:");
            WriteArray(valores);

            // a.	Posiciones de los valores Pares
            Console.WriteLine("\nValores Pares:");
            for (int i = 0; i < valores.Length; i++)
            {
                if(valores[i]%2 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();

            // b.	Posiciones de los valores impares
            Console.WriteLine("\nValores Impares:");
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] % 2 != 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();

            // c.	El mayor valor del arreglo
            int mayor = Int32.MinValue;
            Console.WriteLine("\nValor mayor:");
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > mayor)
                    mayor = valores[i];
            }
            Console.WriteLine(mayor);
        }

        static void ejercicio2()
        {
            Console.WriteLine("\nEjercicio 2: ");

            //Array de valores
            double[] array = RandomDoubleArray(10, 0, 100);

            //Mostrar al usuario el array
            Console.WriteLine("\nValores:");
            WriteArray(array);

            //Aprobados
            double promedio = 0;
            double suma = 0;
            
            //Calculo de promedio
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }
            promedio = suma / array.Length;
            Console.WriteLine($"Promedio: {promedio}");

            //Determinar mayores
            Console.WriteLine("Mayores: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > promedio)
                {
                    Console.Write($"{array[i]} ");
                }
            }

            //Determinar menores
            Console.WriteLine("\nMenores: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < promedio)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }

        static void ejercicio3()
        {
            Console.WriteLine("\nEjercicio 3: ");

            double[] precio = RandomDoubleArray(10, 5, 10);
            double[] descuento = RandomDoubleArray(10, 0, 5);
            int[] cantidad = RandomIntArray(10, 1, 1000);
            
            //Calculo de array de pagos
            double[] pagos = calcularPago(precio, descuento, cantidad);

            Console.WriteLine("\nArray de precios:");
            WriteArray(precio);
            Console.WriteLine("\nArray de descuentos:");
            WriteArray(descuento);
            Console.WriteLine("\nArray de cantidades:");
            WriteArray(cantidad);
            Console.WriteLine("\n\nArray de pago:");
            WriteArray(pagos);
        }

        static double[] calcularPago(double[] precio, double[] descuento, int[] cantidad)
        {
            double[] pagos = new double[10];

            for (int i = 0; i < 10; i++)
            {
                pagos[i] = (precio[i] - descuento[i]) * cantidad[i];
            }

            return pagos;
        }

        static void ejercicio4()
        {
            Console.WriteLine("\nEjercicio 4: ");

            string[] nombres = { "Alan", "Ana", "Francisco", "Gustavo", "Ignacio", "Luis", "Neil"};

            Console.WriteLine("\nArreglo original:");
            WriteArray(nombres);

            for (int i = 0; i < nombres.Length/2; i++)
            {
                string tmp = nombres[i];
                nombres[i] = nombres[nombres.Length - i - 1];
                nombres[nombres.Length - i - 1] = tmp;
            }

            Console.WriteLine("\nArreglo modificado:");
            WriteArray(nombres);
        }

        static void WriteArray<T>(T[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
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

        static double[] RandomDoubleArray(int length, int min, int max)
        {
            Random rand = new Random();
            double[] array = new double[length];

            for (int i = 0; i < length; i++)
            {
                double value = rand.Next(min, max);
                array[i] = value;
            }

            return array;
        }
    }
}
