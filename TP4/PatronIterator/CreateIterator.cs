using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Coleccionables;
using TP4.Comparables;
using TP4.GeneradorRandom;

namespace TP4.PatronIterator
{
    //Esta interfaz se asegura de que cualquier clase que la implemente pueda crear un iterador para su propia colección.
    public interface CreateIterator
    {
        IIterator CreateIterator();
    }
}
