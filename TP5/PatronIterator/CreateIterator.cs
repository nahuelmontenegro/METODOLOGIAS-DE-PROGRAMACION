using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Coleccionables;
using TP5.Comparables;
using TP5.GeneradorRandom;

namespace TP5.PatronIterator
{
    //Esta interfaz se asegura de que cualquier clase que la implemente pueda crear un iterador para su propia colección.
    public interface CreateIterator
    {
        IIterator CreateIterator();
    }
}
