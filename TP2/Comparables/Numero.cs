using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Comparables
{
    public class Numero : IComparable
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

        // Implementación de la interfaz IComparable
        public bool sosIgual(IComparable comparable)
        {
            return ((Numero)comparable).Valor == this.valor;
        }

        public bool sosMenor(IComparable comparable)
        {
            return ((Numero)comparable).Valor > this.valor;
        }

        public bool sosMayor(IComparable comparable)
        {
            return ((Numero)comparable).Valor < this.valor;
        }
    }
}
