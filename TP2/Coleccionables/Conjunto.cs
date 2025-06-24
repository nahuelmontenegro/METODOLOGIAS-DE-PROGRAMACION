using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TP2.Comparables;
using TP2.PatronIterator;
using TP2.PatronStrategy;

namespace TP2.Coleccionables
{
    public class Conjunto : IColeccionable<Persona>, CreateIterator
    {
        //Lista para almacenar los elementos del conjunto
        private List<Persona> almacenamiento;

        //Propiedad para acceder a la lista
        public List<Persona> Almacenamiento
        {
            get { return almacenamiento; }
            private set { almacenamiento = value; }
        }

        //Constructor
        public Conjunto()
        {
            Almacenamiento = new List<Persona>();
        }

        //Agrega un elemento al conjunto si no está presente
        public void agregar(Persona elemento)
        {
            if (!pertenece(elemento))
            {
                Almacenamiento.Add(elemento);
            }
        }

        //Verifica si un elemento pertenece al conjunto
        public bool pertenece(Persona elemento)
        {
            foreach (Persona persona in Almacenamiento)
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
        public Persona minimo()
        {
            if (Almacenamiento.Count == 0) throw new InvalidOperationException("El conjunto está vacío.");

            Persona minimo = Almacenamiento[0];
            foreach (Persona elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(minimo.ToString()) < 0)
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }

        //Devuelve el elemento con el mayor valor basado en ToString()
        public Persona maximo()
        {
            if (Almacenamiento.Count == 0) throw new InvalidOperationException("El conjunto está vacío.");

            Persona maximo = Almacenamiento[0];
            foreach (Persona elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(maximo.ToString()) > 0)
                {
                    maximo = elemento;
                }
            }
            return maximo;
        }

        //Verifica si el conjunto contiene el elemento especificado
        public bool contiene(Persona comparable)
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
