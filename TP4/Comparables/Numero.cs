using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Comparables
{
    public class Numero : IComparableX
    {
        //Propiedad automática para el valor del número
        public int valor;

        public int Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        //Constructor que recibe un valor y lo asigna a la propiedad
        public Numero(int valor)
        {
            this.Valor = valor;
        }

        //Implementación de la interfaz IComparable
        public bool sosIgual(IComparableX comparable)
        {
            return ((Numero)comparable).Valor == this.valor;
        }

        public bool sosMenor(IComparableX comparable)
        {
            return ((Numero)comparable).Valor > this.valor;
        }

        public bool sosMayor(IComparableX comparable)
        {
            return ((Numero)comparable).Valor < this.valor;
        }
    }
}
