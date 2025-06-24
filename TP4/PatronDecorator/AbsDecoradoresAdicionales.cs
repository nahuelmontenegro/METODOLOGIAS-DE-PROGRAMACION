using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.PatronDecorator
{
    public abstract class AbsDecoradoresAdicionales : IImprimirDec
    {
        public Student estudiante;
        public abstract string imprimirDecorado();
    }
}
