using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Comparables;
using TP4.GeneradorRandom;
using TP4.PatronIterator;
using TP4.PatronStrategy;

namespace TP4.Coleccionables
{
    //Definición de la interfaz Coleccionable
    public interface IColeccionable<T> : CreateIterator
    {
        int cuantos();
        T minimo();
        T maximo();
        void agregar(T comparable);
        bool contiene(T comparable);
    }
}
