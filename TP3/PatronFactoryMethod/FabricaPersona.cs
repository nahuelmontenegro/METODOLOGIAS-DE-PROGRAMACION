using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Comparables;
using TP3.GeneradorRandom;

namespace TP3.PatronFactoryMethod
{
    public class FabricaPersona : FabricaDeComparables<Persona>
    {
        public Persona crearAleatorio()
        {
            Generar random = new Generar();
            string nombreAleatorio = random.generarNombre();
            int dniAleatorio = random.generarDNI();
            return new Persona(nombreAleatorio, dniAleatorio);
        }

        public Persona crearPorTeclado()
        {
            LecturaDeDatos lector = new LecturaDeDatos();
            Console.Write("Ingrese nombre: ");
            string nombre = lector.stringPorTeclado();
            Console.Write("Ingrese DNI: ");
            int dni = lector.numeroPorTeclado();
            return new Persona(nombre, dni);
        }
    }
}
