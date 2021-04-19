using System;

namespace TS1C2021_HT11_Repaso_Final
{
    class Program
    {
        private static readonly int NUMFILAS = 5;
        private static readonly int NUMASIENTOS = 7;
        private static readonly int NUMSALAS = 3;
        private static readonly int NUMFUNCIONES = 10;

        private static readonly char LIBRE = 'L';
        private static readonly char OCUPADO = 'O';
        private static readonly char EMITIDO = 'E';
        private static readonly char PENDIENTE = 'P';

        private static double defaultPrice = 50.00;
        private static string categoria0 = "NORMAL";
        private static string categoria1 = "3D";
        private static string categoria2 = "VIP";

        private static char[,] matrizSala1 = SalaVacia(NUMFILAS, NUMASIENTOS);
        private static char[,] matrizSala2 = SalaVacia(NUMFILAS, NUMASIENTOS);
        private static char[,] matrizSala3 = SalaVacia(NUMFILAS, NUMASIENTOS);
        private static char[,] matrizFunciones = FuncionesVacias(NUMSALAS, NUMFUNCIONES);
        private static double[,] categoriaSala = InicializarCategorias(NUMSALAS);
        private static double[] arregloGanancias = new double[NUMSALAS];

        private static double[] precioActual = PrecioActualizado();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("REPASO FINAL - INTRODUCCION A LA PROGRAMACION");

            bool salir = false;
            int opcion = 0;

            while (!salir)
            {
                Console.WriteLine("");
                Console.WriteLine("SISTEMA - ADMINISTRACION DE CINE");
                Console.WriteLine("Ingrese la operación a realizar:");
                Console.WriteLine("1. Configurar/Actualizar configuración");
                Console.WriteLine("2. Vender asiento");
                Console.WriteLine("3. Emitir función");
                Console.WriteLine("4. Cerrar día");
                Console.WriteLine("5. Salir");
                Console.Write("-> ");

                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        MenuConfiguracion();
                        break;
                    case 2:
                        MenuVentas();
                        break;
                    case 3:
                        MenuFunciones();
                        break;
                    case 4:
                        MenuCierre();
                        break;
                    case 5:
                        Console.WriteLine("¡Gracias vuelva pronto!");
                        salir = true;
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void MenuConfiguracion()
        {
            int opcion = 0;

            Console.Clear();
            Console.WriteLine("\nConfigurar / Actualizar configuración\n");
            MostrarConfiguraciones();

            Console.WriteLine("\nIngrese la operación a realizar:");
            Console.WriteLine("1. Configurar Salas");
            Console.WriteLine("2. Regresar");
            Console.Write("-> ");
            opcion = LeerOpcion();

            if (opcion == 1)
            {
                ConfigurarSalas();
            }
        }

        static void ConfigurarSalas()
        {
            int sala = 0;
            int opcion = 0;
            double categoria = 0.0;
            double precio = 0.0;

            Console.Write("\nEscriba el numero de sala a editar: ");
            sala = LeerOpcion();

            if (sala > 0 && sala <= NUMSALAS)
            {
                sala--;

                Console.WriteLine("\nIngrese la operación a realizar:");
                Console.WriteLine("1. Modificar tipo de sala");
                Console.WriteLine("2. Modificar precio");
                Console.Write("-> ");
                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        
                        Console.WriteLine("\nIngrese la categoría de la sala {0}:", sala+1);
                        Console.WriteLine("1. {0}", categoria0);
                        Console.WriteLine("2. {0}", categoria1);
                        Console.WriteLine("3. {0}", categoria2);
                        Console.Write("-> ");
                        opcion = LeerOpcion();

                        if (opcion > 0 && categoria <= 3)
                        {
                            categoria = Convert.ToDouble(opcion);
                            categoria--;

                            categoriaSala[sala, 0] = categoria;
                            Console.WriteLine("Cambios realizados exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Categoría no existe.");
                        }

                        break;

                    case 2:
                        
                        Console.WriteLine("\nIngrese el precio de la sala {0}:", sala + 1);

                        try
                        {
                            precio = Convert.ToDouble(Console.ReadLine());
                            if (precio > 0)
                            {
                                categoriaSala[sala, 1] = precio;
                                Console.WriteLine("Cambios realizados exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("El precio ingresado es inválido.");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Valor inválido.");
                        }

                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Sala no existe.");
            }
        }

        static void MenuVentas()
        {
            int opcion = 0;
            int sala = 0;

            Console.Clear();
            Console.WriteLine("\nVenta de asientos\n");
            
            Console.WriteLine("Ingrese el numero de sala:");
            Console.WriteLine("1. Sala 1: {0}", ObtenerCategoria(categoriaSala[0, 0]));
            Console.WriteLine("2. Sala 2: {0}", ObtenerCategoria(categoriaSala[1, 0]));
            Console.WriteLine("3. Sala 3: {0}", ObtenerCategoria(categoriaSala[2, 0]));
            Console.Write("-> ");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nSala 1:");
                    MostrarSala(matrizSala1);
                    sala = 0;
                    VenderAsiento(ref matrizSala1, sala);
                    break;

                case 2:
                    Console.WriteLine("\nSala 2:");
                    MostrarSala(matrizSala2);
                    sala = 1;
                    VenderAsiento(ref matrizSala2, sala);
                    break;

                case 3:
                    Console.WriteLine("\nSala 3:");
                    MostrarSala(matrizSala3);
                    sala = 2;
                    VenderAsiento(ref matrizSala3, sala);
                    break;

                default:
                    Console.WriteLine("La sala no existe.");
                    break;
            }
        }

        static void VenderAsiento(ref char[,] sala, int codigoSala)
        {
            string columna_ingreso = "";
            string fila_ingreso = "";
            int column_index = 99;
            int row_index = 99;
            
            //Leer valores
            Console.Write("\nEscriba la columna del asiento: ");
            columna_ingreso = Console.ReadLine();
            Console.Write("Escriba la fila del asiento: ");
            fila_ingreso = Console.ReadLine();

            try
            {
                //Establecer valor de fila
                row_index = Convert.ToInt16(fila_ingreso) - 1;
                //Establecer valor de columna
                columna_ingreso = columna_ingreso?.ToUpper();
                column_index = columna_ingreso[0] - 'A';

                //Establecer asiento
                if (column_index < NUMASIENTOS && column_index >= 0 && row_index < NUMFILAS && row_index >= 0)
                {
                    if (sala[row_index, column_index] != OCUPADO)
                    {
                        sala[row_index, column_index] = OCUPADO;
                        Console.WriteLine("\nSala actualizada:");
                        MostrarSala(sala);

                        Console.WriteLine("\nValor total: Q. " + Math.Round(precioActual[codigoSala], 2));
                        arregloGanancias[codigoSala] += precioActual[codigoSala];
                    }
                    else
                    {
                        Console.WriteLine("El asiento ya está ocupado.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor de fila y columna es inválido.");
                }
            }
            catch
            {
                Console.WriteLine("Valor ingresado es inválido.");
            }
        }

        static void MenuFunciones()
        {
            int opcion = 0;
            int sala = 0;

            Console.Clear();
            Console.WriteLine("\nEmitir función:");
            MostrarFuncionesEmitidas();

            Console.WriteLine("\nIngrese el numero de sala:");
            Console.WriteLine("1. Sala 1: {0}", ObtenerCategoria(categoriaSala[0, 0]));
            Console.WriteLine("2. Sala 2: {0}", ObtenerCategoria(categoriaSala[1, 0]));
            Console.WriteLine("3. Sala 3: {0}", ObtenerCategoria(categoriaSala[2, 0]));
            Console.WriteLine("4. Regresar");
            Console.Write("-> ");
            opcion = LeerOpcion();

            if (opcion > 0 && opcion <= NUMSALAS)
            {
                opcion--;
                EmitirFuncion(opcion);
            }
        }

        static void MenuCierre()
        {
            string opcion = "";
            Console.WriteLine("¿Desea cerrar el día? (Y/N): ");
            opcion = Console.ReadLine();

            opcion = opcion.ToUpper();

            if (opcion == "Y")
            {
                Console.WriteLine("\nIngresos del día: \n");

                for (int i = 0; i < NUMSALAS; i++)
                {
                    Console.WriteLine("[Sala {0}] Q. {1}", i+1, Math.Round(arregloGanancias[i], 2));
                }

                ReiniciarValores();
            }
        }

        static void ReiniciarValores()
        {
            VaciarSala(0);
            VaciarSala(1);
            VaciarSala(2);
            matrizFunciones = FuncionesVacias(NUMSALAS, NUMFUNCIONES);
            arregloGanancias = new double[NUMSALAS];
            precioActual = PrecioActualizado();
        }

        static int LeerOpcion()
        {
            int opcion = 0;

            try
            {
                opcion = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entrada Inválida");
            }

            return opcion;
        }

        static char[,] SalaVacia(int filas, int asientos)
        {
            char[,] sala = new char[filas, asientos];

            for (int i = 0; i < sala.GetLength(0); i++)
            {
                for (int j = 0; j < sala.GetLength(1); j++)
                {
                    sala[i, j] = LIBRE;
                }
            }

            return sala;
        }

        static void VaciarSala(int sala)
        {
            switch (sala)
            {
                case 0:
                    matrizSala1 = SalaVacia(NUMFILAS, NUMASIENTOS);
                    break;
                case 1:
                    matrizSala2 = SalaVacia(NUMFILAS, NUMASIENTOS);
                    break;
                case 2:
                    matrizSala3 = SalaVacia(NUMFILAS, NUMASIENTOS);
                    break;
            }
        }

        static char[,] FuncionesVacias(int salas, int funciones)
        {
            char[,] matriz = new char[salas, funciones];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = PENDIENTE;
                }
            }

            return matriz;
        }

        static void EmitirFuncion(int sala)
        {
            bool changed = false;
            for (int i = 0; i < NUMFUNCIONES; i++)
            {
                if (matrizFunciones[sala, i] == PENDIENTE)
                {
                    matrizFunciones[sala, i] = EMITIDO;
                    changed = true;
                    break;
                }
            }

            if (!changed)
            {
                Console.WriteLine("No se pueden emitir más funciones en esa sala.");
            }
            else
            {
                Console.WriteLine("Salas vaciadas y función emitida exitsoamente.");
                VaciarSala(sala);
            }
        }

        private static double[,] InicializarCategorias(int salas)
        {
            double[,] matriz = new double[salas, 2];
            Random rnd = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = (i) % 3;
                matriz[i, 1] = defaultPrice + rnd.NextDouble()*10;
            }

            return matriz;
        }

        static void MostrarSala<T>(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            
            //Imprimir etiqueta de columnas 
            char rowIndex = 'A';
            Console.Write("\t  ");
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"[{rowIndex}] ");
                rowIndex++;
            }
            Console.Write(Environment.NewLine);

            //Imprimir filas
            for (int i = 0; i < rows; i++)
            {
                //Imprimir separadores
                Console.Write("\t ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("____");
                }
                //Imprimir número de fila
                Console.Write("\n[{0}]\t", i + 1);
                //Imprimir valores de fila
                Console.Write(" | ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0} | ", matrix[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

        static void MostrarConfiguraciones()
        {
            double[,] matrix = categoriaSala;
            int rows = matrix.GetLength(0);
            
            //Imprimir filas
            for (int i = 0; i < rows; i++)
            {
                string categoria = ObtenerCategoria(matrix[i, 0]);
                double precio = Math.Round(matrix[i, 1], 2);
                Console.WriteLine("Sala {0}: {1}\t Precio: Q.{2}", i+1, categoria, precio);
            }
        }

        static string ObtenerCategoria(double codigo)
        {
            string categoria;

            switch (codigo)
            {
                case 0.0:
                    categoria = categoria0;
                    break;
                case 1.0:
                    categoria = categoria1;
                    break;
                case 2.0:
                    categoria = categoria2;
                    break;
                default:
                    categoria = "ERROR";
                    break;
            }

            return categoria;
        }

        static double[] PrecioActualizado()
        {
            double[] precios = new double[NUMSALAS];
            int rows = NUMSALAS;

            for (int i = 0; i < rows; i++)
            {
                precios[i] = categoriaSala[i, 1];
            }

            return precios;
        }

        static void MostrarFuncionesEmitidas()
        {
            char[,] matrix = matrizFunciones;

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            //Imprimir etiqueta de columnas 
            int rowIndex = 1;
            Console.Write("\t\t  ");
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"[{rowIndex}] ");
                rowIndex++;
            }
            Console.Write(Environment.NewLine);

            //Imprimir filas
            for (int i = 0; i < rows; i++)
            {
                //Imprimir separadores
                Console.Write("\t\t ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("____");
                }
                //Imprimir número de fila
                Console.Write("\n[Sala: {0}]\t", i + 1);
                //Imprimir valores de fila
                Console.Write(" | ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0} | ", matrix[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
