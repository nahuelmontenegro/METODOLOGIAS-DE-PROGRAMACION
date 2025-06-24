using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Comparables;
using TP2.PatronIterator;
using TP2.PatronStrategy;

namespace TP2.Coleccionables
{
    //Pila LIFO | el último elemento en agregarse es el primero en retirarse
    public class Pila : IColeccionable<Persona>, CreateIterator
    {
        private List<Persona> pila;

        public Pila()
        {
            this.pila = new List<Persona>();
        }
        //Agrega un elemento a la cola.
        public void push(Persona elemento)
        {
            this.pila.Add(elemento);
        }

        //Extrae el último elemento de la pila (LIFO)
        public Persona pop()
        {
            if (isEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            Persona lastElement = pila[pila.Count - 1];
            pila.RemoveAt(pila.Count - 1);
            return lastElement;
        }

        //Devuelve un elemento en una posición específica sin eliminarlo
        public Persona popX(int index)
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
        public Persona top()
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
        public void pushAll(Pila otraPila)
        {
            List<Persona> copia = new List<Persona>(otraPila.pila);
            foreach (Persona elemento in copia)
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
        public Persona minimo()
        {
            if (isEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            Persona minValue = pila[0];
            foreach (Persona elemento in pila)
            {
                if (elemento.sosMenor(minValue))
                    minValue = elemento;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public Persona maximo()
        {
            if (isEmpty())
                throw new InvalidOperationException("La pila está vacía.");

            Persona maxValue = pila[0];
            foreach (Persona elemento in pila)
            {
                if (elemento.sosMayor(maxValue))
                    maxValue = elemento;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Persona comparable)
        {
            this.pila.Add(comparable);
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Persona comparable)
        {
            IIterator iter = CreateIterator();
            while (!iter.EsFin())
            {
                Persona elemento = (Persona)iter.Siguiente();
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