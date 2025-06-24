using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class ColeccionMultiple : IColeccionable
    {
        private Pila pila; //Variable que almacena una pila
        private Cola cola; //Variable que almacena una cola

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        //Implementacion del metodo cuantos: Suma los elementos de la pila y la cola 
        public int cuantos()
        {
            return this.pila.cuantos() + this.cola.cuantos();
        }

        //Implementacion del metodo minimo comparando el minimo entre la pila y la cola
        public IComparable minimo()
        {
            IComparable minimoPila = this.pila.minimo();
            IComparable minimoCola = this.cola.minimo();
            if (minimoPila.sosMenor(minimoCola))
            {
                return minimoPila;
            }
            else
            {
                return minimoCola;
            }
        }

        public IComparable maximo()
        {
            IComparable maximoPila = this.pila.maximo();
            IComparable maximoCola = this.cola.maximo();
            if (maximoPila.sosMayor(maximoCola))
            {
                return maximoPila;
            }
            else
            {
                return maximoCola;
            }
        }

        //No hace nada |
        public void agregar(IComparable comparable)
        {
            throw new NotImplementedException("No se puede agregar a ColeccionMultiple");
        }

        public bool contiene(IComparable comparable)
        {
            bool estaEnPila = this.pila.contiene(comparable);
            bool estaEnCola = this.cola.contiene(comparable);
            //El operador logico or || combina dos condiciones
            if (estaEnPila || estaEnCola)
                return true;
            else
                return false;
        }
        //se podria resumir 
        //return this.pila.contiene(comparable) || this.cola.contiene(comparable);
    }
}
