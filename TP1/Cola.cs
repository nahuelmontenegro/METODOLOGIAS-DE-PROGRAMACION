using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    //Cola FIFO | el primer elemento en agregarse es el primero en retirarse.
    class Cola : IColeccionable
    {
        public List<IComparable> cola;

        public Cola()
        {
            cola = new List<IComparable>();
        }

        //Implementacion de IColeccionable
        public int cuantos()
        {
            return this.cola.Count;
        }

        public IComparable minimo()
        {
            //Corroboro que no este vacia
            if (this.cola.Count == 0)
                throw new InvalidOperationException("La cola está vacía. No se puede determinar un valor minimo.");

            IComparable minimo = this.cola[0];
            for (int i = 0; i < this.cuantos(); i++)
            {
                if (this.cola[i].sosMenor(minimo))
                    minimo = this.cola[i];
            }
            return minimo;
        }

        public IComparable maximo()
        {
            //Corroboro que no este vacia
            if (this.cola.Count == 0)
                throw new InvalidOperationException("La cola está vacía. No se puede determinar un valor máximo.");

            IComparable maximo = this.cola[0];
            for (int i = 0; i < this.cuantos(); i++)
            {
                if (this.cola[i].sosMayor(maximo))
                    maximo = this.cola[i];
            }
            return maximo;
        }
        public void agregar(IComparable coleccionable)
        {
            this.cola.Add(coleccionable);
        }

        public bool contiene(IComparable coleccionable)
        {
            foreach (IComparable a in this.cola)
            {
                if (a.sosIgual(coleccionable))
                    return true;
            }
            return false;
        }
    }

}
