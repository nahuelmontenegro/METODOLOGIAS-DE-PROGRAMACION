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
    public class FabricaAlumno : FabricaDeComparables<Alumno>
    {
        public Alumno crearAleatorio()
        {
            Generar random = new Generar();
            return new Alumno(random.generarNombre(), random.generarDNI(), random.generarDNI(), random.generarPromedio());
        }

        public Alumno crearPorTeclado()
        {
            LecturaDeDatos lector = new LecturaDeDatos();
            Console.Write("Ingrese nombre: ");
            string nombre = lector.stringPorTeclado();
            Console.Write("Ingrese DNI: ");
            int dni = lector.numeroPorTeclado();
            Console.Write("Ingrese legajo: ");
            int legajo = lector.numeroPorTeclado();
            Console.Write("Ingrese promedio: ");
            double promedio = lector.numeroPorTeclado();

            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}
