using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;
using TP5.GeneradorRandom;
using TP5.PatronIterator;
using TP5.PatronStrategy;

namespace TP5.Coleccionables
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
