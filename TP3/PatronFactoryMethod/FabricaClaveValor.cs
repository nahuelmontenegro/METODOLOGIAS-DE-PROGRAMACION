using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Coleccionables;
using TP3.Comparables;
using TP3.GeneradorRandom;

namespace TP3.PatronFactoryMethod
{
    public class FabricaClaveValor : FabricaDeComparables<ClaveValor>
    {
        public ClaveValor crearAleatorio()
        {
            //Generador aleatorio
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

            //Crear clave aleatoria (un número)
            Numero clave = new Numero(generador.numeroAleatorio(1000));

            //Crear valor aleatorio (una Persona)
            Random numeroRandom = new Random();
            Persona valor = new Persona(new GeneradorDeDatosAleatorios().stringAleatorio(numeroRandom.Next(10, 20)), numeroRandom.Next(25000000, 45000000));

            //Retornar el ClaveValor generado
            return new ClaveValor(clave, valor);
        }

        public ClaveValor crearPorTeclado()
        {
            Console.WriteLine("\nPor favor, elija que desea ingresar.");
            Console.WriteLine("1) Un Numero.");
            Console.WriteLine("2) Una Persona.");
            Console.WriteLine("3) Un Alumno.");
            Console.Write("Su opcion: ");

            string opcion = Console.ReadLine();

            //Crear clave desde teclado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nIngrese un número como clave: ");
            Console.ForegroundColor = ConsoleColor.White;
            int numeroClave = new LecturaDeDatos().numeroPorTeclado();
            Numero clave = new Numero(numeroClave);

            //Crear valor según la opción seleccionada
            switch (opcion)
            {
                case "1":
                    //Valor es un Numero
                    Numero numeroValor = (Numero)new FabricaNumero().crearPorTeclado();
                    return new ClaveValor(clave, numeroValor);

                case "2":
                    //Valor es una Persona
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nIngrese un Nombre: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string nombre = new LecturaDeDatos().stringPorTeclado();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nIngrese un Documento: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int documento = new LecturaDeDatos().numeroPorTeclado();
                    Persona personaValor = new Persona(nombre, documento);
                    return new ClaveValor(clave, personaValor);

                case "3":
                    //Valor es un Alumno
                    Alumno alumnoValor = (Alumno)new FabricaAlumno().crearPorTeclado();
                    return new ClaveValor(clave, alumnoValor);

                default:
                    //Opción inválida
                    Console.WriteLine("Opción no válida. Se asignará un valor predeterminado.");
                    return new ClaveValor(clave, new Numero(0));
            }
        }
    }
}
