using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PatronObserver;

namespace TP3.PatronObserver
{
    public interface IObservador
    {
        void actualizar(IObservado observado);
    }
}
//IObservado es el objeto que notifica el cambio 