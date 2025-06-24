using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using TP2.Coleccionables;
using TP2.Comparables;
using TP2.PatronStrategy;
using TP2.GeneradorRandom;
using TP2.PatronIterator;

namespace TP2.Impresiones
{
    public class Main
    {
        public static void Run()
        {
            Cola colaPersonas = new Cola();
            Cola colaAlumnos = new Cola();
            Pila pilaPersonas = new Pila();
            Pila pilaAlumnos = new Pila();

            llenarAlumnos(colaAlumnos);
            llenarAlumnos(pilaAlumnos);
            llenarPersonas(pilaPersonas);
            llenarPersonas(colaPersonas);

            ColeccionMultiple ColeccionMultuplePersonas = new ColeccionMultiple(pilaPersonas, colaPersonas);
            ColeccionMultiple ColeccionMultupleAlumnos = new ColeccionMultiple(pilaAlumnos, colaAlumnos);

            informarPersonas(ColeccionMultuplePersonas);
            informarPersonas(ColeccionMultupleAlumnos);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tPila y Cola de Personas:\n");
            Console.ForegroundColor = ConsoleColor.White;
            informarPersonas(ColeccionMultuplePersonas);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tPila y Cola de Alumnos:\n");
            Console.ForegroundColor = ConsoleColor.White;
            informarPersonas(ColeccionMultupleAlumnos);
        }

        public static void Run2()
        {
            //Ejercicio 8
            Pila newPila = new Pila();
            Cola newCola = new Cola();
            Conjunto newConjunto = new Conjunto();
            Diccionario newDiccionario = new Diccionario();
            llenarAlumnos(newPila);
            llenarAlumnos(newCola);
            llenarAlumnos((IColeccionable<Persona>)newConjunto);
            llenarAlumnosDiccionario(newDiccionario);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tPila: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementos(newPila);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tCola: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementos(newCola);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tConjunto: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementos((IColeccionable<Persona>)newConjunto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tDiccionario: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementosDiccionario(newDiccionario);
        }

        public static void Run3()
        {	//Ej10
            Pila newPila = new Pila();
            llenarAlumnos(newPila);
            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorNombre());
            informar(newPila);

            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorDNI());
            informar(newPila);

            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorLegajo());
            informar(newPila);

            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorPromedio());
            informar(newPila);

            Console.WriteLine();
            PatronIterator.Main.imprimirElementos(newPila);
        }
        public static void informarPersonas(ColeccionMultiple inColeccionable)
        {
            Console.WriteLine("\n\tLa cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos() + "\n" +
                              "\tLa cantidad de elementos que existen en la Pila son: " + inColeccionable.cuantos() + "\n" +
                              "\tLa Persona con menor numero de DNI entre la Cola y la Pila es: " + inColeccionable.minimo().DNI + "\n" +
                              "\tLa Persona con mayor numero de DNI entre la Cola y la Pila es: " + inColeccionable.maximo().DNI);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion:\t");
            Console.ForegroundColor = ConsoleColor.White;
            int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario", input);
            if (inColeccionable.contiene(newElemento))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tEl elemento ingresado esta en la coleccion\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tEl elemento ingresado no se encuentra en la coleccion");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void llenarAlumnos(IColeccionable<Persona> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 5; i++)
            {
                Alumno unAlumno = new Alumno(generar.generarNombre(), generar.generarDNI(), generar.generarLegajo(), generar.generarPromedio());
                coleccion.agregar(unAlumno);
            }
        }
        public static void llenarAlumnosDiccionario(IColeccionable<ClaveValor> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Alumno unAlumno = new Alumno(generar.generarNombre(), generar.generarDNI(), generar.generarLegajo(), generar.generarPromedio());
                ((Diccionario)coleccion).agregar(unAlumno);
            }
        }
        public static void llenarPersonas(IColeccionable<Persona> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Persona unaPersona = new Persona(generar.generarNombre(), generar.generarDNI());
                coleccion.agregar(unaPersona);
            }
        }
        public static void informar(IColeccionable<Persona> coleccion)
        {
            Alumno maximo = (Alumno)coleccion.maximo();
            Alumno minimo = (Alumno)coleccion.minimo();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tElementos de la Coleccion:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tMaximo:\n\t\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}\n" +
                "\tMinimo:\n\t\tAlumno: {4}\tDNI: {5}\tLegajo: {6}\tPromedio: {7}",
                     maximo.Nombre, maximo.DNI, maximo.Legajo, maximo.Promedio,
                     minimo.Nombre, minimo.DNI, minimo.Legajo, minimo.Promedio);
        }
    }
}


