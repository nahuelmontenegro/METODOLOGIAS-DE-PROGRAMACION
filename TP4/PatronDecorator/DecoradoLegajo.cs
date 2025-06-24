using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.PatronAdapter;

namespace TP4.PatronDecorator
{
    public class DecoradoLegajo : AbsDecoradoresAdicionales
    {
        public DecoradoLegajo(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string imprimirDecorado()
        {
            AdapterStudent alumno = (AdapterStudent)base.estudiante;
            string showCalification = alumno.showResult();
            string[] splitCalification = showCalification.Split('\t');
            string decoratedCalification = splitCalification[0] + " (" + alumno.Adaptado.Legajo + ") " + "\t" + splitCalification[1];
            return decoratedCalification;
        }
    }
}
