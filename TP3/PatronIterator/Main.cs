using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PatronIterator;
using TP3.PatronStrategy;
using TP3.Coleccionables;
using TP3.Comparables;
using TP3.Impresiones;

namespace TP3.PatronIterator
{
    public class Main
    {
        public static void Run()
        {
            Cola unaCola = new Cola();
            Impresiones.Main.llenarAlumnos(unaCola);
            imprimirElementos(unaCola);
        }

        public static void imprimirElementos(IColeccionable<IComparableX> coleccion)
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
    }
}
