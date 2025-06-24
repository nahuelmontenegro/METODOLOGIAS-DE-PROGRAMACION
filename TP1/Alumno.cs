using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Alumno : Persona
    {
        //Nuevas variables específicas de Alumno
        private int legajo;
        private int promedio;

        //Constructor que recibe nombre, DNI, legajo y promedio
        public Alumno(string n, int d, int l, int p) : base(n, d)  //Llamada al constructor de la clase base (Persona)
        {
            this.legajo = l;
            this.promedio = p;
        }
        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        //Comparo Personas por el promedio
        override public bool sosIgual(IComparable comparable)
        {
            if (((Alumno)(comparable)).getPromedio() == this.promedio)
                return true;
            else
                return false;
        }

        override public bool sosMenor(IComparable comparable)
        {
            if (((Alumno)(comparable)).getLegajo() > this.legajo)
                return true;
            else
                return false;
        }

        override public bool sosMayor(IComparable comparable)
        {
            if (((Alumno)(comparable)).getLegajo() < this.legajo)
                return true;
            else
                return false;
        }




    }
}
