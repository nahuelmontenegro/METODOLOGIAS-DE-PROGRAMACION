using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Coleccionables;
using TP5.Comparables;
using TP5.GeneradorRandom;

namespace TP5.PatronIterator
{
    public class ConcreteIteratorDiccionario : IIterator
    {
        public Diccionario lista;
        public int posicionActual;

        //Constructor que inicializa el diccionario y la posición actual
        public ConcreteIteratorDiccionario(Diccionario enLista)
        {
            this.lista = enLista;
            this.posicionActual = 0;
        }

        //Verifica si se ha alcanzado el final de la colección
        public bool EsFin()
        {
            return posicionActual >= lista.cuantos();
        }

        //Reinicia el iterador al inicio de la colección
        public void Reset()
        {
            posicionActual = 0;
        }

        //Devuelve el siguiente valor en el diccionario
        public object Siguiente()
        {
            if (EsFin())
                throw new InvalidOperationException("No hay más elementos en el diccionario.");

            //Devuelve el valor asociado a la clave en la posición actual
            object valor = lista.ListaClaveValor[posicionActual].valor;
            posicionActual++;
            return valor;
        }

        //Devuelve el siguiente par ClaveValor en el diccionario
        public ClaveValor SiguienteClaveValor()
        {
            if (EsFin())
                throw new InvalidOperationException("No hay más elementos en el diccionario.");

            ClaveValor claveValor = lista.ListaClaveValor[posicionActual];
            posicionActual++;
            return claveValor;
        }
    }
}
