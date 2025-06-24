//Rodrigo Montenegro
using System;
using System.IO;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)  //Simplicidad en la comparación booleana
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t Elija una opción: \n\t *****************\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t1) Correr programa");
                Console.WriteLine("\t0) Salir\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\tIngrese su opción: ");
                Console.ForegroundColor = ConsoleColor.White;

                //Validar la entrada del usuario
                if (int.TryParse(Console.ReadLine(), out int eleccion))
                {
                    switch (eleccion)
                    {
                        case 1:
                            TP.Main.RunTP();  //Correr el programa principal
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 0:
                            salir = true;  //Salir del programa
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\tOpción inválida. Por favor, elija una opción válida.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tEntrada no válida. Por favor, ingrese un número.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}