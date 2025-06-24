using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.PatronDecorator
{
    public class DecoradoRecuadroAsteriscos : AbsDecoradoresAdicionales
    {
        public DecoradoRecuadroAsteriscos(Student estudiante)
        {
            base.estudiante = estudiante;
        }

        public override string imprimirDecorado()
        {
            string asteriscos = "";
            for (int i = 0; i < base.estudiante.showResult().Length; i++) { asteriscos += "*"; }
            asteriscos += "**************";

            string decoratedCalification = asteriscos + "\n" +
               "*\t" + base.estudiante.showResult() + "\t*" +
               "\n" + asteriscos;
            return decoratedCalification;
        }
    }
}
