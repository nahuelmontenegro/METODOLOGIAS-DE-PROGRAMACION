//Rodrigo Montenegro
using System;
using System.IO;
using TP5.GeneradorRandom;

namespace TP5
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (salir.Equals(false))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t Elija una opcion: " + "\n\t *****************\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t1) Comparar Nombre");
                Console.WriteLine("\t2) Comparar DNI");
                Console.WriteLine("\t3) Comparar Legajo");
                Console.WriteLine("\t4) Comparar Promedio");
                Console.WriteLine("\t5) Informar Personas");
                Console.WriteLine("\t6) Prueba Patron Iterador");
                Console.WriteLine("\t7) Imprimir Elementos");
                Console.WriteLine("\t8) Informar Máximos y Mínimos");
                Console.WriteLine("\t9) Test de la Clase GeneradorDeDatosAleatorios");
                Console.WriteLine("\t10) Llenar, informar y comparar Comparables");
                Console.WriteLine("\t11) Llenar, informar y comparar Vendedores");
                Console.WriteLine("\t12) Patron Observer");
                Console.WriteLine("\t13) Patron Adapter");
                Console.WriteLine("\t14) Patron Decorator");
                Console.WriteLine("\t15) Patron Proxy");
                Console.WriteLine("\t16) Patron Command");
                Console.WriteLine("\t0) Salir");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\tIngrese su opcion: ");
                Console.ForegroundColor = ConsoleColor.White;
                int eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.Clear();
                        PatronStrategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        PatronStrategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        PatronStrategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        PatronStrategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Impresiones.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        PatronIterator.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Impresiones.Main.Run2();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Impresiones.Main.Run3();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Write("\nElija la cantidad de caracteres que desea tener el nombre (mayor a 10): ");
                        int opcion = new LecturaDeDatos().numeroPorTeclado();
                        Console.WriteLine("Nombre: " + new GeneradorDeDatosAleatorios().stringAleatorio(opcion));
                        Console.Write("\n\nElija un numero maximo del cual obtener un numero aleatorio: ");
                        opcion = new LecturaDeDatos().numeroPorTeclado();
                        Console.WriteLine("Numero: " + new GeneradorDeDatosAleatorios().numeroAleatorio(opcion));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 10:
                        Impresiones.Main.Run4();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 11:
                        Impresiones.Main.Run5();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 12:
                        PatronObserver.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 13:
                        PatronAdapter.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 14:
                        PatronDecorator.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 15:
                        PatronProxy.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 16:
                        PatronCommand.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        salir = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("\tElija una opcion.");
                        Console.Clear();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}