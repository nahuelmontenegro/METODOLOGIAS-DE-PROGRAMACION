using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.PatronCommand
{
    public interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 OEA1);
        void setOrdenLlegaAlumno(OrdenEnAula2 OEA2);
        void setOrdenAulaLlena(OrdenEnAula1 OEA1);
    }
}
