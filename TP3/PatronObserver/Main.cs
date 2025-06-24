using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Coleccionables;
using TP3.Comparables;
using TP3.GeneradorRandom;
using TP3.PatronIterator;

namespace TP3.PatronObserver
{
    public class Main
    {
        public static void Run()
        {
            //Crear una instancia de profesor
            Profesor profesor = new Profesor("Isac Gomez", 30557555, 15);

            //Crear una lista o conjunto de alumnos
            List<Alumno> alumnos = new List<Alumno>();

            //Generar 20 alumnos aleatorios
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Alumno alumno = new Alumno(
                    generar.generarNombre(),
                    generar.generarDNI(),
                    generar.generarLegajo(),
                    generar.generarPromedio());

                // Agregar al profesor como observable
                profesor.agregarObservador(alumno);

                // Añadir el alumno a la lista para otras operaciones si es necesario
                alumnos.Add(alumno);
            }

            //Llamar al método dictadoDeClases desde la instancia de profesor
            Console.WriteLine("Iniciando el dictado de clases...");
            profesor.dictadoDeClases();
        }
    }
}
