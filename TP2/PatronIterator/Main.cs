using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.PatronIterator;
using TP2.PatronStrategy;
using TP2.Coleccionables;
using TP2.Comparables;
using TP2.Impresiones;

namespace TP2.PatronIterator
{
    public class Main
    {
        public static void Run()
        {
            //Crear una cola y llenar con alumnos
            Cola unaCola = new Cola();
            Impresiones.Main.llenarAlumnos(unaCola);

            //Imprimir elementos de la cola
            imprimirElementos(unaCola);
        }

        public static void imprimirElementos(IColeccionable<Persona> coleccion)
        {
            IIterator iter = coleccion.CreateIterator();
            while (!iter.EsFin())
            {
                Alumno elemento = (Alumno)iter.Siguiente();
                Console.WriteLine("\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}",
                     elemento.Nombre, elemento.DNI, elemento.Legajo, elemento.Promedio);
            }
        }
        public static void imprimirElementosDiccionario(IColeccionable<ClaveValor> coleccion)
        {
            IIterator iter = coleccion.CreateIterator();
            while (!iter.EsFin())
            {
                Alumno elemento = (Alumno)iter.Siguiente();
                Console.WriteLine("\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}",
                     elemento.Nombre, elemento.DNI, elemento.Legajo, elemento.Promedio);
            }
        }

        internal static void imprimirElementos(Diccionario newDiccionario)
        {
            throw new NotImplementedException();
        }
    }
}
