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
    public class Diccionario : IColeccionable<IComparableX>, CreateIterator
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
        public void agregar(Numero clave, IComparableX valor)
        {
            int indice = indiceElemento(clave);
            if (indice == -1)
            {
                ListaClaveValor.Add(new ClaveValor(clave, valor));
            }
            else
            {
                ListaClaveValor[indice].valor = valor;
            }
        }

        //Método para agregar un objeto Persona utilizando la clave por defecto
        public void agregar(IComparableX valor)
        {
            int indice = indiceElemento(ClaveDefault);
            if (indice == -1)
            {
                ListaClaveValor.Add(new ClaveValor(new Numero(ClaveDefault.valor), valor));
                ClaveDefault.valor += 1;
            }
            else
            {
                ListaClaveValor[indice].valor = valor;
            }
        }

        //Busca y retorna la posición del elemento con la clave dada, o -1 si no existe
        public int indiceElemento(Numero clave)
        {
            for (int i = 0; i < ListaClaveValor.Count; i++)
            {
                if (ListaClaveValor[i].clave.valor == clave.valor)
                    return i;
            }
            return -1;
        }

        //Retorna el valor asociado a la clave ingresada, o null si no existe
        public IComparableX valorDe(Numero clave)
        {
            int indice = indiceElemento(clave);
            return indice != -1 ? ListaClaveValor[indice].valor : null;
        }

        //Devuelve la cantidad de elementos en el diccionario
        public int cuantos()
        {
            return ListaClaveValor.Count;
        }

        //Devuelve el elemento de menor valor basado en el DNI de Persona
        public IComparableX minimo()
        {
            ConcreteIteratorDiccionario iter = new ConcreteIteratorDiccionario(this);
            ClaveValor minimo = (ClaveValor)iter.Siguiente();
            while (!iter.EsFin())
            {
                ClaveValor elemento = (ClaveValor)iter.Siguiente();
                minimo = elemento.valor.sosMenor(minimo) ? elemento : minimo;
            }
            return minimo;
        }

        public IComparableX maximo()
        {
            ConcreteIteratorDiccionario iter = new ConcreteIteratorDiccionario(this);
            ClaveValor maximo = (ClaveValor)iter.Siguiente();
            while (!iter.EsFin())
            {
                ClaveValor elemento = (ClaveValor)iter.Siguiente();
                maximo = elemento.valor.sosMayor(maximo) ? elemento : maximo;
            }
            return maximo;
        }

        //Método para agregar un objeto de tipo ClaveValor
        public void agregar(ClaveValor comparable)
        {
            agregar((Numero)comparable.clave, (IComparableX)comparable.valor);
        }

        //Verifica si el diccionario contiene un elemento con el valor dado
        public bool contiene(IComparableX comparable)
        {
            IIterator iter = CreateIterator();
            while (!iter.EsFin())
            {
                ClaveValor elemento = (ClaveValor)iter.Siguiente();
                if (elemento.sosIgual(comparable))
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
