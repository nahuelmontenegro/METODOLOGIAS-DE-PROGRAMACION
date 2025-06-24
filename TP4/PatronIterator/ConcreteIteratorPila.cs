using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Coleccionables;
using TP4.Comparables;
using TP4.GeneradorRandom;

namespace TP4.PatronIterator
{
    public class ConcreteIteratorPila : IIterator
    {
        public Pila lista;
        public int posicionActual;

        //Constructor que inicializa la pila y la posición actual
        public ConcreteIteratorPila(Pila enLista)
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
                throw new InvalidOperationException("No hay más elementos en la pila.");

            //Devuelve el elemento en la posición actual y avanza el iterador
            object elemento = lista.popX(posicionActual);
            posicionActual++;
            return elemento;
        }
    }
}
