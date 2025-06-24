using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.PatronDecorator
{
    public class DecoradoPromocion : AbsDecoradoresAdicionales
    {
        public DecoradoPromocion(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string imprimirDecorado()
        {
            string decoratedCalification = "";
            if (base.estudiante.getScore() >= 7)
            {
                decoratedCalification = base.estudiante.showResult() + "(PROMOCION)";
            }
            else if (base.estudiante.getScore() >= 4)
            {
                decoratedCalification = base.estudiante.showResult() + "(APROBADO)";
            }
            else
            {
                decoratedCalification = base.estudiante.showResult() + "(DESAPROBADO)";
            }

            return decoratedCalification;
        }
    }
}
