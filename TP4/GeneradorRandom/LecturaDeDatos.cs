using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.GeneradorRandom
{
    internal class LecturaDeDatos
    {
        //Método para leer un número entero desde el teclado con manejo de errores
        public int numeroPorTeclado()
        {
            int numeroIngresado;
            while (true)
            {
                Console.Write("Ingrese un número entero: ");
                string entradaTexto = Console.ReadLine();

                //Intenta convertir la entrada en un número entero
                if (int.TryParse(entradaTexto, out numeroIngresado))
                {
                    return numeroIngresado;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Por favor, ingrese un número válido.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        //Método para leer una cadena de texto desde el teclado
        public string stringPorTeclado()
        {
            Console.Write("Ingrese un texto: ");
            string textoIngresado = Console.ReadLine();
            return textoIngresado;
        }
    }
}
