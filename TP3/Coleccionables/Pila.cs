using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Comparables;
using TP3.GeneradorRandom;
using TP3.PatronIterator;
using TP3.PatronStrategy;

namespace TP3.Coleccionables
{
    //Pila LIFO | el último elemento en agregarse es el primero en retirarse
    public class Pila : IColeccionable<IComparableX>, CreateIterator
    {
        List<IComparableX> pila;

        public Pila()
        {
            this.pila = new List<IComparableX>();
        }
        //Agrega un elemento a la cola.
        public void push(IComparableX elemento)
        {
            this.pila.Add(elemento);
        }

        //Extrae el último elemento de la pila (LIFO)
        public IComparableX pop()
        {
            if (isEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            IComparableX lastElement = pila[pila.Count - 1];
            pila.RemoveAt(pila.Count - 1);
            return lastElement;
        }

        //Devuelve un elemento en una posición específica sin eliminarlo
        public IComparableX popX(int index)
        {
            if (index < 0 || index >= pila.Count)
                throw new ArgumentOutOfRangeException("Índice fuera de rango.");

            return pila[pila.Count - index - 1];
        }

        //Verifica si la pila está vacía
        public bool isEmpty()
        {
            return pila.Count == 0;
        }

        //Devuelve el último elemento de la pila sin eliminarlo
        public IComparableX top()
        {
            if (isEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            return pila[pila.Count - 1];
        }

        //Devuelve la cantidad de elementos en la pila
        public int size()
        {
            return pila.Count;
        }

        //Invierte el orden de los elementos y devuelve una nueva pila
        public Pila reverse()
        {
            Pila reversedPila = new Pila();
            for (int i = pila.Count - 1; i >= 0; i--)
            {
                reversedPila.push(pila[i]);
            }
            return reversedPila;
        }

        //Agrega todos los elementos de otra pila a la pila actual sin modificar la pila original
        public void pushAll(Pila newCola)
        {
            List<IComparableX> copia = new List<IComparableX>(newCola.pila);
            foreach (IComparableX elemento in copia)
            {
                this.push(elemento);
            }
        }

        //Implementacion Heredados
        //Devuelve la cantidad de elementos comparables que tiene el coleccionable
        public int cuantos()
        {
            return this.pila.Count;
        }

        //Devuelve el elemento de menor valor de la colección
        public IComparableX minimo()
        {
            if (isEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            IComparableX minValue = pila[0];
            foreach (IComparableX elemento in pila)
            {
                if (elemento.sosMenor(minValue))
                    minValue = elemento;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public IComparableX maximo()
        {
            if (isEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            IComparableX maxValue = pila[0];
            foreach (IComparableX elemento in pila)
            {
                if (elemento.sosMayor(maxValue))
                    maxValue = elemento;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(IComparableX comparable)
        {
            this.pila.Add(comparable);
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(IComparableX comparable)
        {
            IIterator iter = CreateIterator();
            while (!iter.EsFin())
            {
                IComparableX elemento = (IComparableX)iter.Siguiente();
                if (comparable.sosIgual(elemento))
                    return true; //Retorna inmediatamente si se encuentra el elemento
            }
            return false; //Si no se encuentra, retorna false
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIteratorPila(this);
        }
    }
}