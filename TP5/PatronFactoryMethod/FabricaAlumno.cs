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
    public class FabricaAlumno : FabricaDeComparables
    {
        public IComparableX crearAleatorio()
        {
            //Genera un alumno con datos aleatorios
            Generar random = new Generar();
            return new Alumno(random.generarNombre(), random.generarDNI(), random.generarDNI(), random.generarPromedio());
        }

        public IComparableX crearPorTeclado()
        {
            //Crear un alumno con datos ingresados por el usuario
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
