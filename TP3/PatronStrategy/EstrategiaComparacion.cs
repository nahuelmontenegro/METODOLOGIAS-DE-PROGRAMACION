using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Comparables;
using TP3.PatronObserver;

namespace TP3.PatronStrategy
{
    public class EstrategiaComparacionPorNombre : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre).Equals(0);
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) > 0;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) < 0;
        }
    }

    public class EstrategiaComparacionPorDNI : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return comparable.DNI.Equals(invocador.DNI);
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return comparable.DNI > invocador.DNI;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return comparable.DNI < invocador.DNI;
        }
    }
    public class EstrategiaComparacionPorPromedio : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio.Equals(((Alumno)invocador).Promedio);
        }
        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio > ((Alumno)invocador).Promedio;
        }
        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio < ((Alumno)invocador).Promedio;
        }
    }
    public class EstrategiaComparacionPorLegajo : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo.Equals(((Alumno)invocador).Legajo);
        }
        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo > ((Alumno)invocador).Legajo;
        }
        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo < ((Alumno)invocador).Legajo;
        }
    }
    public class EstrategiaComparacionPorAntiguedad : IStrategy<Profesor>
    {
        public bool sosIgual(Profesor invocador, Profesor comparable)
        {
            return invocador.Antiguedad == comparable.Antiguedad;
        }

        public bool sosMenor(Profesor invocador, Profesor comparable)
        {
            return invocador.Antiguedad < comparable.Antiguedad;
        }

        public bool sosMayor(Profesor invocador, Profesor comparable)
        {
            return invocador.Antiguedad > comparable.Antiguedad;
        }
    }
}
