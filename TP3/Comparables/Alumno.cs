using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PatronObserver;
using TP3.PatronStrategy;

namespace TP3.Comparables
{
    public class Alumno : Persona, IObservador
    {
        //Campos privados
        private int legajo;
        private double promedio;

        //Propiedades
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public double Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        //Constructor que recibe nombre, DNI, legajo y promedio
        public Alumno(string nombre, int dni, int legajo, double promedio)
        {
            Nombre = nombre;
            DNI = dni;
            Legajo = legajo;
            Promedio = promedio;
            Estrategia = new EstrategiaComparacionPorDNI();
        }

        public void actualizar(IObservado observado)
        {
            if (observado is Profesor profesor)
            {
                if (profesor.EstaHablando) //Un campo que indica la acción actual del profesor
                {
                    prestarAtencion();
                }
                else
                {
                    distraerse();
                }
            }
        }

        public void prestarAtencion()
        {
            Console.WriteLine($"{Nombre}: Prestando atención.");
        }

        public void distraerse()
        {
            var distracciones = new[] { "Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel" };
            Console.WriteLine($"{Nombre}: {distracciones[new Random().Next(distracciones.Length)]}");
        }

        public bool sosIgual(Persona comparable)
        {
            return base.Estrategia.sosIgual(this, comparable);
        }

        public bool sosMenor(Persona comparable)
        {
            return base.Estrategia.sosMenor(this, comparable);
        }

        public bool sosMayor(Persona comparable)
        {
            return base.Estrategia.sosMayor(this, comparable);
        }
    }
}
