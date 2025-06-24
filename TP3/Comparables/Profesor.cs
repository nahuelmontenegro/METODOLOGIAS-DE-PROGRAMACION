using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PatronObserver;

namespace TP3.Comparables
{
    public class Profesor : Persona, IObservado

    {
        private List<IObservador> observadores;

        //Propiedad para almacenar la antigüedad del profesor (en años)
        public int Antiguedad { get; set; }

        //Constructor que inicializa el nombre, DNI y antigüedad
        public Profesor(string nombre, int dni, int antiguedad) : base(nombre, dni)
        {
            Antiguedad = antiguedad;
            observadores = new List<IObservador>();
        }

        //Propiedad para indicar si el profesor está hablando
        public bool EstaHablando { get; private set; }

        //Implementacion Observer
        public void agregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (var observador in observadores)
            {
                observador.actualizar((IObservado)this);
            }
        }

        public void hablarALaClase()
        {
            EstaHablando = true;
            Console.WriteLine("Profesor: Hablando de algún tema.");
            notificar();
        }

        public void escribirEnElPizarron()
        {
            EstaHablando = false;
            Console.WriteLine("Profesor: Escribiendo en el pizarrón.");
            notificar();
        }

        //Método dictadoDeClases dentro de la clase Profesor
        public void dictadoDeClases()
        {
            for (int i = 0; i < 5; i++)
            {
                hablarALaClase();
                escribirEnElPizarron();
            }
        }
    }
}
