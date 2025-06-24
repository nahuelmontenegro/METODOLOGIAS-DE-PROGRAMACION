using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Comparables;
using TP3.GeneradorRandom;

namespace TP3.PatronFactoryMethod
{
    public interface FabricaDeComparables<T>
    {
        //Método para crear una instancia aleatoria
        T crearAleatorio();

        //Método para crear una instancia ingresada por teclado
        T crearPorTeclado();
    }
}