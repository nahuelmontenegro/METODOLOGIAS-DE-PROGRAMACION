using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.PatronIterator;

namespace TP2.Coleccionables
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
