using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PatronStrategy;

namespace TP3.Comparables
{
    public class Persona : IComparableX
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
        public bool sosIgual(IComparableX comparable)
        {
            return Estrategia.sosIgual(this, (Persona)comparable);
        }

        public bool sosMenor(IComparableX comparable)
        {
            return Estrategia.sosMenor(this, (Persona)comparable);
        }

        public bool sosMayor(IComparableX comparable)
        {
            return Estrategia.sosMayor(this, (Persona)comparable);
        }
    }
}
