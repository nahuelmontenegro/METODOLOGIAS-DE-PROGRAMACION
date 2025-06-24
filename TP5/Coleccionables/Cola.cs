using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.PatronIterator;
using TP5.Coleccionables;
using TP5.Comparables;
using TP5.PatronCommand;

namespace TP5.Coleccionables
{
    //Cola FIFO | el primer elemento en agregarse es el primero en retirarse.
    public class Cola : IColeccionable<IComparableX>, CreateIterator, Ordenable
    {
        List<IComparableX> cola;
        public OrdenEnAula1 OrdenInicioEnAula { get; set; }
        public OrdenEnAula1 OrdenEnAulaLlena { get; set; }
        public OrdenEnAula2 OrdenLlegaAlumno { get; set; }

        public Cola()
        {
            cola = new List<IComparableX>();
        }

        //Agrega un elemento a la cola (FIFO)
        public void push(IComparableX elemento)
        {
            this.cola.Add(elemento);
        }

        //Extraer el primer elemento de la cola (FIFO)
        public IComparableX pop()
        {
            if (isEmpty())
                throw new InvalidOperationException("La cola está vacía.");

            IComparableX firstElement = this.cola[0];
            this.cola.RemoveAt(0);
            return firstElement;
        }

        //Devuelve un elemento en una posición específica sin eliminarlo
        public IComparableX popX(int index)
        {
            if (index < 0 || index >= this.cola.Count)
                throw new ArgumentOutOfRangeException("Índice fuera de rango.");

            return this.cola[index];
        }

        //Verifica si la cola está vacía
        public bool isEmpty()
        {
            return this.cola.Count == 0;
        }

        //Devuelve el primer elemento de la cola sin eliminarlo
        public IComparableX top()
        {
            if (isEmpty())
                throw new InvalidOperationException("La cola está vacía.");

            return this.cola[0];
        }

        //Devuelve la cantidad de elementos en la cola
        public int size()
        {
            return this.cola.Count;
        }

        //Invierte el orden de los elementos y devuelve una nueva cola
        public Cola reverse()
        {
            Cola reversedCola = new Cola();
            for (int i = this.cola.Count - 1; i >= 0; i--)
            {
                reversedCola.push(this.cola[i]);
            }
            return reversedCola;
        }

        //Agrega todos los elementos de otra cola a la cola actual sin modificar la cola original
        public void pushAll(Cola newCola)
        {
            for (int i = 0; i < newCola.size(); i++)
            {
                this.cola.Add(newCola.pop());
            }
        }
        //Devuelve la cantidad de elementos comparables que tiene el coleccionable
        public int cuantos()
        {
            return this.cola.Count;
        }

        //Devuelve el elemento de menor valor de la colección
        public IComparableX minimo()
        {
            if (isEmpty())
                throw new InvalidOperationException("La cola está vacía.");

            IComparableX minValue = this.cola[0];
            foreach (IComparableX elemento in this.cola)
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
                throw new InvalidOperationException("La cola está vacía.");

            IComparableX maxValue = this.cola[0];
            foreach (IComparableX elemento in this.cola)
            {
                if (elemento.sosMayor(maxValue))
                    maxValue = elemento;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(IComparableX comparable)
        {
            if (this.cola.Count.Equals(0) && OrdenInicioEnAula != null)
                OrdenInicioEnAula.ejecutar();

            this.cola.Add(comparable);
            if (OrdenLlegaAlumno != null)
                OrdenLlegaAlumno.ejecutar(comparable);

            if (this.cola.Count.Equals(39) && OrdenEnAulaLlena != null)
                OrdenEnAulaLlena.ejecutar();
        }

        //Devuelve verdadero si el comparable recibido está en la colección
        public bool contiene(IComparableX comparable)
        {
            IIterator iter = CreateIterator();
            while (!iter.EsFin())
            {
                IComparableX elemento = (IComparableX)iter.Siguiente();
                if (comparable.sosIgual(elemento))
                    return true;
            }
            return false;
        }

        //Implementa la interfaz CreateIterator para crear un iterador
        public IIterator CreateIterator()
        {
            return new ConcreteIteratorCola(this);
        }

        //Implemeta la interfaz Ordenable
        public void setOrdenInicio(OrdenEnAula1 OEA1)
        {
            OrdenInicioEnAula = OEA1;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 OEA2)
        {
            OrdenLlegaAlumno = OEA2;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 OEA1)
        {
            OrdenEnAulaLlena = OEA1;
        }
    }
}
