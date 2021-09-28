using System;

namespace TS2C2021_HT05_Estructuras_Repetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int opcion = 0;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Ingrese el numero de ejercicio:");
                Console.WriteLine("1. Par o impar");
                Console.WriteLine("2. Numeros en fila");
                Console.WriteLine("3. Suma divisibles entre 9");
                Console.WriteLine("4. Tablas de multiplicar");
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
                        salir = true;
                        break;
                }
            }
        }

        static void ejercicio1()
        {
            Console.WriteLine("\nEjercicio 1: ");
            int x = 0;
            Console.WriteLine("Ingrese un número:");

            do
            {
                try
                {
                    x = int.Parse(Console.ReadLine()!);
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("Número es par");
                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine(a.Message);
                }
            }
            while (x != 99);

            Console.WriteLine("Proceso finalizado.");
            Console.ReadLine();
        }

        static void ejercicio2()
        {
            Console.WriteLine("\nEjercicio 2: ");
            int x;
            
            try
            {
                Console.WriteLine("\nIngrese número de filas: ");
                x = int.Parse(Console.ReadLine()!);

                Console.Write("\n");

                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.Write("\n");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

            Console.WriteLine("\nProceso finalizado.");
            Console.ReadLine();
        }

        static void ejercicio3()
        {
            Console.WriteLine("\nEjercicio 3: ");

            Console.WriteLine("\nNúmero entre 100 y 200 divisibles entre 9:\n");

            int suma = 0;

            for (int i = 100; i <= 200; i++)
            {
                if ( i % 9 == 0)
                {
                    Console.Write( i + " ");
                    suma += i;
                }
            }

            Console.WriteLine("\n\nResultado suma:\n");

            Console.WriteLine(suma);

            Console.WriteLine("\nProceso finalizado.");
            Console.ReadLine();
        }

        static void ejercicio4()
        {
            Console.WriteLine("\nEjercicio 4: ");
            int x;

            try
            {
                Console.WriteLine("\nIngrese un número: ");
                x = int.Parse(Console.ReadLine()!);

                Console.Write("\n");

                for (int k = 1; k <= x; k++)
                {
                    Console.WriteLine($"Tabla de {k}: \n");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{k} * {i} = {k * i}");
                    }
                    Console.Write("\n");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

            Console.WriteLine("\nProceso finalizado.");
            Console.ReadLine();
        }
    }
}
