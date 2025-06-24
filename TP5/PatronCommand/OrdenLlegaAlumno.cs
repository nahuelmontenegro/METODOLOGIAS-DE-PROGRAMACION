using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;

namespace TP5.PatronCommand
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        public Aula Aula2 { get; set; }

        public OrdenLlegaAlumno(Aula enAula)
        {
            Aula2 = enAula;
        }
        public void ejecutar(IComparableX a)
        {
            Aula2.nuevoAlumno((Alumno)a);
        }
    }
}
