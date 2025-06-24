using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    //Pila LIFO | el último elemento en agregarse es el primero en retirarse
    class Pila : IColeccionable
    {
        public List<IComparable> pila;

        public Pila()
        {
            this.pila = new List<IComparable>();
        }

        //Implementacion de IColeccionable
        public int cuantos()
        {
            return this.pila.Count;
        }

        public IComparable minimo()
        {
            //Corroboro que no este vacia
            if (this.pila.Count == 0)
                throw new InvalidOperationException("La pila está vacía. No se puede determinar un valor minimo.");

            IComparable minimo = this.pila[0];
            for (int i = 0; i < this.cuantos(); i++)
            {
                if (this.pila[i].sosMenor(minimo))
                    minimo = this.pila[i];
            }
            return minimo;
        }

        public IComparable maximo()
        {
            //Corroboro que no este vacia
            if (this.pila.Count == 0)
                throw new InvalidOperationException("La pila está vacía. No se puede determinar un valor máximo.");

            IComparable maximo = this.pila[0];
            for (int i = 0; i < this.cuantos(); i++)
            {
                if (this.pila[i].sosMayor(maximo))
                    maximo = this.pila[i];
            }
            return maximo;
        }

        public void agregar(IComparable coleccionable)
        {
            this.pila.Add(coleccionable);
        }

        public bool contiene(IComparable coleccionable)
        {
            foreach (IComparable a in pila)
            {
                if (a.sosIgual(coleccionable))
                    return true;
            }
            return false;
        }
    }
}