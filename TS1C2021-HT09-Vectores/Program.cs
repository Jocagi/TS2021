using System;

namespace TS1C2021_HT09_Vectores
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
                Console.WriteLine("1. Ej1-Medidas");
                Console.WriteLine("2. Ej2-Notas");
                Console.WriteLine("3. Ej3-Sucursales");
                Console.WriteLine("4. Ej4-Reemplazo");
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

            int[] MEDIDAS = {85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93};

            //Mostrar al usuario el array
            Console.WriteLine("\nMedidas:");
            WriteArray(MEDIDAS);

            // a.	Medida en la posición 2 * posición 3
            Console.WriteLine("\nMedida en la posición 2 * posición 3:");
            Console.WriteLine(MEDIDAS[2] * MEDIDAS[3]);
            // b.	La medida de la mitad del arreglo
            Console.WriteLine("\nMedida de la mitad del arreglo:");
            Console.WriteLine(MEDIDAS[6]);
            // c.	La medida del final del arreglo
            Console.WriteLine("\nMedida del final del arreglo:");
            Console.WriteLine(MEDIDAS[12]);
            // d.	Medida en la posición 5
            Console.WriteLine("\nMedida en la posición 5:");
            Console.WriteLine(MEDIDAS[5]);
            // e.	Medida en la posición 10
            Console.WriteLine("\nMedida en la posición 10:");
            Console.WriteLine(MEDIDAS[10]);
            //f.	Medida en la posición 1* posición 2
            Console.WriteLine("\nMedida en la posición 1* posición 2:");
            Console.WriteLine(MEDIDAS[1] * MEDIDAS[2]);
        }

        static void ejercicio2()
        {
            Console.WriteLine("\nEjercicio 2: ");

            //Array de notas
            double[] NOTAS = RandomDoubleArray(10, 0, 100);
            
            //Aprobados
            double PROMEDIO_A = 0;
            double SUMA_A = 0;
            int APROBADOS = 0;

            //Reprobados
            double PROMEDIO_R = 0;
            double SUMA_R = 0;
            int REPROBADOS = 0;

            //Calculo de promedio
            for (int i = 0; i < NOTAS.Length; i++)
            {
                if (NOTAS[i] >= 60)
                {
                    APROBADOS++;
                    SUMA_A += NOTAS[i];
                }
                else
                {
                    REPROBADOS++;
                    SUMA_R += NOTAS[i];
                }
            }

            PROMEDIO_A = SUMA_A / APROBADOS;
            PROMEDIO_R = SUMA_R / REPROBADOS;
            
            //Imprimir resultado
            WriteArray(NOTAS);
            Console.WriteLine("Promedio Aprobados: " + PROMEDIO_A);
            Console.WriteLine("Promedio Reprobados: " + PROMEDIO_R);
        }

        static void ejercicio3()
        {
            Console.WriteLine("\nEjercicio 3: ");

            int[] SUCURSAL_A = RandomIntArray(10, 0, 10);
            int[] SUCURSAL_B = RandomIntArray(10, 0, 10);
            double[] PRECIOS = RandomDoubleArray(10, 1, 1000);
            double[] RECAUDACION = new double[10];
            
            for(int i = 0; i < 10; i++)
            {
                RECAUDACION[i] = (SUCURSAL_A[i] + SUCURSAL_B[i]) * PRECIOS[i];
            }

            Console.WriteLine("\nInventario Sucursal 1:");
            WriteArray(SUCURSAL_A);
            Console.WriteLine("\nInventario Sucursal 2:");
            WriteArray(SUCURSAL_B);
            Console.WriteLine("\nPrecio de artículos:");
            WriteArray(PRECIOS);
            Console.WriteLine("\nRecaudación:");
            WriteArray(RECAUDACION);
        }

        static void ejercicio4()
        {
            Console.WriteLine("\nEjercicio 4: ");

            double[] ARREGLO = { 96, 67, 32, 58, 52, 15, 42 };

            Console.WriteLine("\nArreglo original:");
            WriteArray(ARREGLO);

            for (int i = 0; i < ARREGLO.Length; i++)
            {
                if (ARREGLO[i] < 50)
                {
                    ARREGLO[i] = 25;
                }    
            }

            Console.WriteLine("\nArreglo modificado:");
            WriteArray(ARREGLO);
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
