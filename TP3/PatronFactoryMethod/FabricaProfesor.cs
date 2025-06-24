using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Comparables;
using TP3.GeneradorRandom;

namespace TP3.PatronFactoryMethod
{
    public class FabricaProfesor : FabricaDeComparables<Profesor>
    {
        public Profesor crearAleatorio()
        {
            Generar random = new Generar();
            string nombreAleatorio = random.generarNombre();
            int dniAleatorio = random.generarDNI();
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            int antiguedad = generador.numeroAleatorio(15);
            return new Profesor(nombreAleatorio, dniAleatorio, antiguedad);
        }

        public Profesor crearPorTeclado()
        {
            LecturaDeDatos lector = new LecturaDeDatos();

            Console.Write("Ingrese nombre: ");
            string nombre = lector.stringPorTeclado();

            Console.Write("Ingrese DNI: ");
            int dni = lector.numeroPorTeclado();

            Console.Write("Ingrese los años de antiguedad del profesor: ");
            int antiguedad = lector.numeroPorTeclado();

            return new Profesor(nombre, dni, antiguedad);
        }
    }
}
