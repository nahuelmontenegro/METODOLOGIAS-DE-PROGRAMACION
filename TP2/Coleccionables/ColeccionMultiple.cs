using System;
using System.Collections.Generic;
using System.Text;
using TP2.Comparables;
using TP2.GeneradorRandom;
using TP2.PatronIterator;
using TP2.PatronStrategy;

namespace TP2.Coleccionables
{
    public class ColeccionMultiple : IColeccionable<Persona>
    {
        public Pila pilaInterna;
        public Cola colaInterna;

        //Constructor que recibe una pila y una cola
        public ColeccionMultiple(Pila inPila, Cola inCola)
        {
            this.pilaInterna = inPila;
            this.colaInterna = inCola;
        }

        //Devuelve la cantidad total de elementos en ambas colecciones
        public int cuantos()
        {
            return this.pilaInterna.cuantos() + this.colaInterna.cuantos();
        }

        //Devuelve una lista con la cantidad de elementos en la Pila y la Cola
        public List<int> cuantosPorColeccion()
        {
            return new List<int> { pilaInterna.cuantos(), colaInterna.cuantos() };
        }

        // Devuelve el elemento de menor valor de la colección
        public Persona minimo()
        {
            Persona minimoCola = colaInterna.minimo();
            Persona minimoPila = pilaInterna.minimo();
            return minimoCola.sosMenor(minimoPila) ? minimoCola : minimoPila;
        }

        // Devuelve el elemento de mayor valor de la colección
        public Persona maximo()
        {
            Persona maximoCola = colaInterna.maximo();
            Persona maximoPila = pilaInterna.maximo();
            return maximoCola.sosMayor(maximoPila) ? maximoCola : maximoPila;
        }

        //Lanza una excepción ya que no es posible agregar elementos a una colección múltiple
        public void agregar(Persona comparable)
        {
            throw new NotImplementedException("No se puede agregar elementos a ColeccionMultiple");
        }

        //Devuelve verdadero si el elemento se encuentra en la pila o en la cola
        public bool contiene(Persona comparable)
        {
            return this.colaInterna.contiene(comparable) || this.pilaInterna.contiene(comparable);
        }

        //Implementación para crear un iterador (a implementar en el futuro)
        public IIterator CreateIterator()
        {
            throw new NotImplementedException();
        }
    }
}
