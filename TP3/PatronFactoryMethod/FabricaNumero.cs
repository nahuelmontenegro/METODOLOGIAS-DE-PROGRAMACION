using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Comparables;
using TP3.GeneradorRandom;

namespace TP3.PatronFactoryMethod
{
    public class FabricaNumero : FabricaDeComparables<Numero>
    {
        public Numero crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return new Numero(generador.numeroAleatorio(100)); //Generar un número entre 0 y 100
        }

        public Numero crearPorTeclado()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Por favor, ingrese un numero: ");
            Console.ForegroundColor = ConsoleColor.White;
            int usuario = Convert.ToInt32(Console.ReadLine());
            return new Numero(usuario);
        }
    }
}
