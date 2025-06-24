using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.PatronIterator;
using TP5.PatronStrategy;
using TP5.Coleccionables;
using TP5.Comparables;
using TP5.Impresiones;

namespace TP5.PatronIterator
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
