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
    class FabricaAlumnoMuyEstudiosoProxy : FabricaDeComparables
    {
        public IComparableX crearAleatorio()
        {
            Generar random = new Generar();
            AlumnoMuyEstudiosoProxy registro = new AlumnoMuyEstudiosoProxy(random.generarNombre(), random.generarDNI(), random.generarDNI(), random.generarPromedio());
            //registro.Calificacion = new Random().Next(1, 10);
            return registro;
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
            Console.Write("Por favor, ingrese una Calificacion: ");
            string calificacion = Console.ReadLine();
            AlumnoMuyEstudiosoProxy registro = new AlumnoMuyEstudiosoProxy(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToDouble(promedio));
            registro.Calificacion = Convert.ToDouble(calificacion);
            return registro;
        }
    }
}
