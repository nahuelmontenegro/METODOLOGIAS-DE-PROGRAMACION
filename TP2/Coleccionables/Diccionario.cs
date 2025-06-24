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
    public class Diccionario : IColeccionable<ClaveValor>, CreateIterator
    {
        //Campos privados
        private List<ClaveValor> claveValor;
        private Numero Default;

        //Propiedad para acceder a la lista de ClaveValor
        public List<ClaveValor> ListaClaveValor
        {
            get { return claveValor; }
            private set { claveValor = value; }
        }

        //Propiedad para la clave por defecto
        public Numero ClaveDefault
        {
            get { return Default; }
            set { Default = value; }
        }

        //Constructor
        public Diccionario()
        {
            ListaClaveValor = new List<ClaveValor>();
            ClaveDefault = new Numero(0);
        }

        //Método para agregar un par clave-valor usando Numero y Persona
        public void agregar(Numero clave, Persona valor)
        {
            int indice = indiceElemento(clave);
            if (indice == -1)
            {
                ListaClaveValor.Add(new ClaveValor(clave, valor));
            }
            else
            {
                ListaClaveValor[indice].Valor = valor;
            }
        }

        //Método para agregar un objeto Persona utilizando la clave por defecto
        public void agregar(Persona valor)
        {
            int indice = indiceElemento(ClaveDefault);
            if (indice == -1)
            {
                ListaClaveValor.Add(new ClaveValor(new Numero(ClaveDefault.Valor), valor));
                ClaveDefault.Valor += 1;
            }
            else
            {
                ListaClaveValor[indice].Valor = valor;
            }
        }

        //Busca y retorna la posición del elemento con la clave dada, o -1 si no existe
        public int indiceElemento(Numero clave)
        {
            for (int i = 0; i < ListaClaveValor.Count; i++)
            {
                if (ListaClaveValor[i].Clave.Valor == clave.Valor)
                    return i;
            }
            return -1;
        }

        //Retorna el valor asociado a la clave ingresada, o null si no existe
        public object valorDe(Numero clave)
        {
            int indice = indiceElemento(clave);
            return indice != -1 ? ListaClaveValor[indice].Valor : null;
        }

        //Devuelve la cantidad de elementos en el diccionario
        public int cuantos()
        {
            return ListaClaveValor.Count;
        }

        //Devuelve el elemento de menor valor basado en el DNI de Persona
        public ClaveValor minimo()
        {
            if (ListaClaveValor.Count == 0)
                throw new InvalidOperationException("El diccionario está vacío.");

            ClaveValor minimo = ListaClaveValor[0];
            foreach (ClaveValor elemento in ListaClaveValor)
            {
                if (((Persona)elemento.Valor).DNI < ((Persona)minimo.Valor).DNI)
                    minimo = elemento;
            }
            return minimo;
        }

        //Devuelve el elemento de mayor valor basado en el DNI de Persona
        public ClaveValor maximo()
        {
            if (ListaClaveValor.Count == 0)
                throw new InvalidOperationException("El diccionario está vacío.");

            ClaveValor maximo = ListaClaveValor[0];
            foreach (ClaveValor elemento in ListaClaveValor)
            {
                if (((Persona)elemento.Valor).DNI > ((Persona)maximo.Valor).DNI)
                    maximo = elemento;
            }
            return maximo;
        }

        //Método para agregar un objeto de tipo ClaveValor
        public void agregar(ClaveValor comparable)
        {
            agregar((Numero)comparable.Clave, (Persona)comparable.Valor);
        }

        //Verifica si el diccionario contiene un elemento con el valor dado
        public bool contiene(ClaveValor comparable)
        {
            foreach (ClaveValor elemento in ListaClaveValor)
            {
                if (elemento.Valor.Equals(comparable.Valor))
                    return true;
            }
            return false;
        }

        //Método para crear un iterador
        public IIterator CreateIterator()
        {
            return new ConcreteIteratorDiccionario(this);
        }
    }
}
