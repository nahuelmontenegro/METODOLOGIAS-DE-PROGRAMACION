using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;
using TP5.GeneradorRandom;
using TP5.PatronProxy;

namespace TP5.PatronFactoryMethod
{
    class FabricaAlumnoProxy : FabricaDeComparables
    {
        public IComparableX crearAleatorio()
        {
            Generar random = new Generar();
            return new AlumnoProxy(random.generarNombre(), random.generarDNI(), random.generarDNI(), random.generarPromedio());
        }

        public IComparableX crearPorTeclado()
        {
            Console.Write("Por favor, ingrese un Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Documento: ");
            string documento = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Legajo: ");
            string legajo = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Promedio: ");
            string promedio = Console.ReadLine();

            return new AlumnoProxy(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToDouble(promedio));
        }
    }
}
