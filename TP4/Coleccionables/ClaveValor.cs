using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Comparables;

namespace TP4.Coleccionables
{
    public class ClaveValor : IComparableX
    {
        public Numero clave;
        public IComparableX valor;
        public ClaveValor(Numero clave, IComparableX valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        //Implementar estos tres metodos en Diccionario para comparar
        //Y asi romper con la funcion exclusiva para diccionario.
        public bool sosIgual(IComparableX comparable)
        {
            return this.valor.sosIgual(comparable);
        }

        public bool sosMayor(IComparableX comparable)
        {
            return this.valor.sosMayor(comparable);
        }

        public bool sosMenor(IComparableX comparable)
        {
            return this.valor.sosMenor(comparable);
        }
    }
}
