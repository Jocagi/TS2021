using System;

namespace TS1C2021_Estructuras_Repetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int opcion = 0;
            
            while (!salir)
            {
                Console.WriteLine("");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Ingrese el numero de ejercicio:");
                Console.WriteLine("1. Multiplos de 3");
                Console.WriteLine("2. Numeros aleatorios");
                Console.WriteLine("3. Suma n impares");
                Console.WriteLine("4. Intereses banco");
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
            int x = 33;
            Console.WriteLine("Los multiplos de 3 son:");
            
            do
            {
                Console.WriteLine(x);
                x -= 3;
            } 
            while (x >= 3);
        }

        static void ejercicio2()
        {
            Console.WriteLine("\nEjercicio 2: ");
            Random random = new Random();
            int x = random.Next(1, 10);
            int y = 0;


            Console.WriteLine("Adivine el numero aleatorio:");

            while (y != x)
            {
                Console.WriteLine("Ingrese un numero: ");
                try
                {
                    y = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    y = -1;
                    Console.WriteLine(e);
                }

                if (y == -1)
                {
                    Console.WriteLine("Numero invalido");
                }
                else if (y > x)
                {
                    Console.WriteLine("Muy alto");
                }
                else if (y < x)
                {
                    Console.WriteLine("Muy bajo");
                }
                else if (y == x)
                {
                    Console.WriteLine("Adivinaste!");
                }
            }
        }

        static void ejercicio3()
        {
            int n;
            int count = 0;
            int sum = 0;

            Console.WriteLine("\nEjercicio 3: ");
            Console.WriteLine("Suma de los primeros n impares...");

            Console.WriteLine("Ingrese 'n': ");
            try
            {
                n = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                n = 0;
                Console.WriteLine(e);
            }

            while (n > 0)
            {
                count++;
                if (count % 2 != 0)
                {
                    sum += count;
                    n--;
                }
            }
            Console.WriteLine("Total: " + sum);
        }

        static void ejercicio4()
        {
            int n;
            double dinero = 1000.00;

            Console.WriteLine("\nEjercicio 4: ");
            Console.WriteLine("Total despues de n años con una tasa de interes del 8%...");

            Console.WriteLine("Ingrese 'n': ");
            try
            {
                n = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                n = 0;
                Console.WriteLine(e);
            }

            while (n > 0)
            {
                dinero = dinero + dinero * 0.08;
                n--;
            }

            Console.WriteLine("El total es: Q." + dinero);
        }
    }
}
