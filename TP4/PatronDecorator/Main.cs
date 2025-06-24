using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.PatronAdapter;
using TP4.Comparables;
using TP4.PatronFactoryMethod;
using MetodologíasDeProgramaciónI;

namespace TP4.PatronDecorator
{
    public class Main
    {
        public static void Run()
        {
            //setear calificacion
            Student adaptado = new AdapterStudent((Alumno)new FabricaAlumno().crearAleatorio());
            DecoradoLegajo a = new DecoradoLegajo(adaptado);
            string imprimir = new DecoradoLegajo(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoradoNotasEnLetras b = new DecoradoNotasEnLetras(a.estudiante); //Alumno
            imprimir = new DecoradoNotasEnLetras(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoradoPromocion c = new DecoradoPromocion(b.estudiante);
            imprimir = new DecoradoPromocion(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoradoRecuadroAsteriscos d = new DecoradoRecuadroAsteriscos(c.estudiante);
            imprimir = new DecoradoRecuadroAsteriscos(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            imprimir = d.imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();
        }
    }
}
