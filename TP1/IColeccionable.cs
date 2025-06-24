using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    //Definición de la interfaz Coleccionable
    interface IColeccionable
    {
        int cuantos();
        IComparable minimo();
        IComparable maximo();
        void agregar(IComparable c);
        bool contiene(IComparable c);
    }
}
