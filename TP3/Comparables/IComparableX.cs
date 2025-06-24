using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Comparables
{
    //Definición de la interfaz Comparable
    public interface IComparableX
    {
        bool sosIgual(IComparableX comparable);

        bool sosMenor(IComparableX comparable);

        bool sosMayor(IComparableX comparable);
    }
}
