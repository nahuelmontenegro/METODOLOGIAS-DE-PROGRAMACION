using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.PatronIterator;
using TP4.PatronStrategy;
using TP4.Coleccionables;
using TP4.Comparables;
using TP4.Impresiones;

namespace TP4.PatronIterator
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
