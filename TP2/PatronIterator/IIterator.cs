using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.PatronIterator
{
    public interface IIterator
    {
        //Devuelve el siguiente elemento en la colección
        object Siguiente();

        //Verifica si se ha alcanzado el final de la colección
        bool EsFin();

        //Reinicia el iterador al inicio de la colección
        void Reset();
    }
}
