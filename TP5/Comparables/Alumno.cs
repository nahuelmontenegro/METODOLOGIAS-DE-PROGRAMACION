using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.PatronDecorator;
using TP5.PatronStrategy;

namespace TP5.Comparables
{
    public class Alumno : Persona, IImprimirDec
    {
        //Campos privados
        private int legajo;
        private double promedio;
        private double calificacion;

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

        public double Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
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
        public int responderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }

        public string mostrarCalificacion()
        {
            return this.Nombre + "\t" + this.Calificacion;
        }

        public string imprimirDecorado()
        {
            throw new NotImplementedException();
        }
    }
}
