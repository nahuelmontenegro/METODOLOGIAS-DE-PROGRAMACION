using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Coleccionables;
using TP5.Comparables;
using TP5.GeneradorRandom;

namespace TP5.PatronFactoryMethod
{
    public class FabricaClaveValor : FabricaDeComparables
    {
        public IComparableX crearAleatorio()
        {
            Random numeroRandom = new Random();
            Persona persona = new Persona(new GeneradorDeDatosAleatorios().stringAleatorio(numeroRandom.Next(10, 20)), numeroRandom.Next(25000000, 45000000));
            return new ClaveValor(new Numero(numeroRandom.Next()), persona);
        }

        public IComparableX crearPorTeclado()
        {
            Console.WriteLine("\nPor favor, elija que desea ingresar.");
            Console.WriteLine("1) Un Numero.");
            Console.WriteLine("2) Una Persona.");
            Console.WriteLine("3) Un Alumno.");
            Console.Write("Su opcion: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nIngrese el numero escogido: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Numero numero = (Numero)new FabricaNumero().crearPorTeclado();
                    return numero;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nIngrese un Nombre: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string nombre = new LecturaDeDatos().stringPorTeclado();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nIngrese un Documento: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int documento = new LecturaDeDatos().numeroPorTeclado();
                    return new Persona(nombre, documento);
                case "3":
                    return new FabricaAlumno().crearPorTeclado();
                default:
                    return new Numero(0);
            }
        }
    }
}
