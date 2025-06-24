using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TP4.Comparables;
using TP4.GeneradorRandom;
using TP4.PatronIterator;
using TP4.PatronStrategy;

namespace TP4.Coleccionables
{
    public class Conjunto : IColeccionable<IComparableX>, CreateIterator
    {
        //Lista para almacenar los elementos del conjunto
        public List<IComparableX> almacenamiento;

        //Propiedad para acceder a la lista
        public List<IComparableX> Almacenamiento
        {
            get { return almacenamiento; }
            private set { almacenamiento = value; }
        }

        //Constructor
        public Conjunto()
        {
            Almacenamiento = new List<IComparableX>();
        }

        //Agrega un elemento al conjunto si no está presente
        public void agregar(IComparableX elemento)
        {
            if (!pertenece(elemento))
            {
                Almacenamiento.Add(elemento);
            }
        }

        //Verifica si un elemento pertenece al conjunto
        public bool pertenece(IComparableX elemento)
        {
            foreach (IComparableX persona in Almacenamiento)
            {
                if (persona.Equals(elemento))
                    return true;
            }
            return false;
        }

        //Devuelve la cantidad de elementos en el conjunto
        public int cuantos()
        {
            return Almacenamiento.Count;
        }

        //Devuelve el elemento con el menor valor basado en ToString()
        public IComparableX minimo()
        {
            IComparableX minimo = Almacenamiento[0];
            foreach (IComparableX elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(minimo.ToString()) < 0)
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }

        //Devuelve el elemento con el mayor valor basado en ToString()
        public IComparableX maximo()
        {
            IComparableX maximo = Almacenamiento[0];
            foreach (IComparableX elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(maximo.ToString()) < 0)
                {
                    maximo = elemento;
                }
            }
            return maximo;
        }

        //Verifica si el conjunto contiene el elemento especificado
        public bool contiene(IComparableX comparable)
        {
            return Almacenamiento.Contains(comparable);
        }

        //Crea un iterador para el conjunto
        public IIterator CreateIterator()
        {
            return new ConcreteIteratorConjunto(this);
        }
    }
}
