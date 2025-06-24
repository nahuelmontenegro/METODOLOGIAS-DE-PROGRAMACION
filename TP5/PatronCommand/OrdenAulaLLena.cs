using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.PatronCommand
{
    public class OrdenAulaLlena : OrdenEnAula1
    {
        public Aula Aula1 { get; set; }

        public OrdenAulaLlena(Aula salon)
        {
            Aula1 = salon;
        }

        public void ejecutar()
        {
            Aula1.claseLista();
        }
    }
}
