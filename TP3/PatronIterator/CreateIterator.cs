using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Coleccionables;
using TP3.Comparables;
using TP3.GeneradorRandom;

namespace TP3.PatronIterator
{
    //Esta interfaz se asegura de que cualquier clase que la implemente pueda crear un iterador para su propia colección.
    public interface CreateIterator
    {
        IIterator CreateIterator();
    }
}
