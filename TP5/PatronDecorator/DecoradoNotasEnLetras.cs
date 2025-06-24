using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.PatronDecorator
{
    public class DecoradoNotasEnLetras : AbsDecoradoresAdicionales
    {
        public DecoradoNotasEnLetras(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string imprimirDecorado()
        {
            string decoratedCalification = base.estudiante.showResult() + "(" + letrasXnumeros(base.estudiante.getScore()) + ")";
            return decoratedCalification;
        }

        private string letrasXnumeros(int aConvertir)
        {
            string[] numerosConvertidos = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            return numerosConvertidos[aConvertir];
        }
    }
}
