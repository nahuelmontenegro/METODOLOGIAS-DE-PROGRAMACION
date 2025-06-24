using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.PatronCommand
{
    public class OrdenInicio : OrdenEnAula1
    {
        public Aula Aula1 { get; set; }

        public OrdenInicio(Aula salon)
        {
            Aula1 = salon;
        }

        public void ejecutar()
        {
            Aula1.comenzar();
        }
    }
}
