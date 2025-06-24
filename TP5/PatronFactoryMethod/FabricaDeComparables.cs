using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;
using TP5.GeneradorRandom;

namespace TP5.PatronFactoryMethod
{
    public interface FabricaDeComparables
    {
        IComparableX crearAleatorio();
        IComparableX crearPorTeclado();
    }
}