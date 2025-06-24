//Rodrigo Montenegro
using System;
using System.IO;

namespace TP2
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