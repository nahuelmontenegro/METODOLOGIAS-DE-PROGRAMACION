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
    public class ConcreteIteratorConjunto : IIterator
    {
        public Conjunto lista;
        public int posicionActual;

        //Constructor que inicializa la colección y la posición actual
        public ConcreteIteratorConjunto(Conjunto enLista)
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

        //Devuelve el siguiente elemento en la colección
        public object Siguiente()
        {
            if (EsFin())
                throw new InvalidOperationException("No hay más elementos en el conjunto.");

            object elemento = lista.Almacenamiento[posicionActual];
            posicionActual++;
            return elemento;
        }
    }
}
