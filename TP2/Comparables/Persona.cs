using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.PatronStrategy;

namespace TP2.Comparables
{
    public class Persona : IComparable
    {
        //Campos privados
        private string nombre;
        private int dni;
        private IStrategy<Persona> estrategia;

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public IStrategy<Persona> Estrategia
        {
            get { return estrategia; }
            set { estrategia = value; }
        }

        //Constructores
        public Persona(string nombre, int dni)
        {
            Nombre = nombre;
            DNI = dni;
            Estrategia = new EstrategiaComparacionPorDNI();
        }
        public Persona()
        {
            Estrategia = new EstrategiaComparacionPorDNI();
        }

        //Implementación de IComparable usando la estrategia
        public bool sosIgual(IComparable comparable)
        {
            return Estrategia.sosIgual(this, (Persona)comparable);
        }

        public bool sosMenor(IComparable comparable)
        {
            return Estrategia.sosMenor(this, (Persona)comparable);
        }

        public bool sosMayor(IComparable comparable)
        {
            return Estrategia.sosMayor(this, (Persona)comparable);
        }
    }
}
