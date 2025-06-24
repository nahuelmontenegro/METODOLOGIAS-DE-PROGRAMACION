using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Persona : IComparable
    {
        //Variables protegidas para acceso desde clases derivadas
        protected string nombre;
        protected int dni;

        //Construcctor
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }

        //Métodos para obtener nombre y DNI
        public string getNombre()
        {
            return this.nombre;
        }
        public int getDNI()
        {
            return this.dni;
        }

        //Implementacion IComparable para comparar personas por Nombre y por DNI 
        virtual public bool sosIgual(IComparable comparable)
        {
            if (((Persona)(comparable)).getDNI() == this.dni)
                return true;
            else
                return false;
        }

        virtual public bool sosMenor(IComparable comparable)
        {
            if (((Persona)(comparable)).getDNI() > this.dni)
                return true;
            else
                return false;
        }

        virtual public bool sosMayor(IComparable comparable)
        {
            if (((Persona)(comparable)).getDNI() < this.dni)
                return true;
            else
                return false;
        }

    }
}
