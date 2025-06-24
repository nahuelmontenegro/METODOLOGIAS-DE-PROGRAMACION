using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Comparables;
using TP4.GeneradorRandom;

namespace TP4.PatronFactoryMethod
{
    public interface FabricaDeComparables
    {
        IComparableX crearAleatorio();
        IComparableX crearPorTeclado();
    }
}