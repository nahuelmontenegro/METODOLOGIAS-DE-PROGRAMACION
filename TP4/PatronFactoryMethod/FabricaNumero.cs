using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Comparables;
using TP4.GeneradorRandom;

namespace TP4.PatronFactoryMethod
{
    public class FabricaNumero : FabricaDeComparables
    {
        public IComparableX crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return new Numero(generador.numeroAleatorio(100)); //Generar un número entre 0 y 100
        }

        public IComparableX crearPorTeclado()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Por favor, ingrese un numero: ");
            Console.ForegroundColor = ConsoleColor.White;
            int usuario = Convert.ToInt32(Console.ReadLine());
            return new Numero(usuario);
        }
    }
}
