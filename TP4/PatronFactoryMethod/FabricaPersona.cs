using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Comparables;
using TP4.GeneradorRandom;

namespace TP4.PatronFactoryMethod
{
    public class FabricaPersona : FabricaDeComparables
    {
        //Crear una Persona con datos aleatorios
        public IComparableX crearAleatorio()
        {
            //Generar datos aleatorios usando la clase Generar
            Generar random = new Generar();
            string nombreAleatorio = random.generarNombre();
            int dniAleatorio = random.generarDNI();

            //Retornar una nueva instancia de Persona
            return new Persona(nombreAleatorio, dniAleatorio);
        }

        //Crear una Persona con datos ingresados por el usuario
        public IComparableX crearPorTeclado()
        {
            // Usar la clase LecturaDeDatos para solicitar información al usuario
            LecturaDeDatos lector = new LecturaDeDatos();
            Console.Write("Ingrese nombre: ");
            string nombre = lector.stringPorTeclado();
            Console.Write("Ingrese DNI: ");
            int dni = lector.numeroPorTeclado();

            // Retornar una nueva instancia de Persona con los datos ingresados
            return new Persona(nombre, dni);
        }
    }
}
