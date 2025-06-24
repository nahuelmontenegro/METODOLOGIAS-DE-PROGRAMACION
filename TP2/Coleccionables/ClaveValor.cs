using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Comparables;

namespace TP2.Coleccionables
{
    public class ClaveValor
    {
        public Numero Clave;
        public object Valor;
        public ClaveValor(Numero clave, Persona valor)
        {
            this.Clave = clave;
            this.Valor = valor;
        }
    }
}
