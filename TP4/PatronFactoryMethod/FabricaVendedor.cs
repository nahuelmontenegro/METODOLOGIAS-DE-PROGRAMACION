using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Comparables;
using TP4.GeneradorRandom;
using TP4.PatronObserver;

namespace TP4.PatronFactoryMethod
{
    public class FabricaVendedor : FabricaDeComparables
    {
        public IComparableX crearAleatorio()
        {
            string nombre = new GeneradorDeDatosAleatorios().stringAleatorio(15);
            int dni = new GeneradorDeDatosAleatorios().numeroAleatorio(45000000);
            double sueldo = new GeneradorDeDatosAleatorios().numeroAleatorio(50000);
            Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            return newVendedor;
        }

        public IComparableX crearPorTeclado()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Por favor, ingrese un Nombre: ");
            Console.ForegroundColor = ConsoleColor.White;
            string nombre = new LecturaDeDatos().stringPorTeclado();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPor favor, ingrese un Documento: ");
            Console.ForegroundColor = ConsoleColor.White;
            int dni = new LecturaDeDatos().numeroPorTeclado();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPor favor, ingrese un Sueldo Basico: ");
            Console.ForegroundColor = ConsoleColor.White;
            double sueldo = new LecturaDeDatos().numeroPorTeclado();
            Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            return newVendedor;
        }
    }
}
