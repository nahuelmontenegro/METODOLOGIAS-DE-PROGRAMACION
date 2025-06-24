using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Comparables;

namespace TP2.PatronStrategy
{
    public class EstrategiaComparacionPorNombre : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) == 0;
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
            return comparable.DNI == invocador.DNI;
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
            if (invocador is Alumno alumnoInv && comparable is Alumno alumnoComp)
            {
                return alumnoComp.Legajo == alumnoInv.Legajo;
            }
            return false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            if (invocador is Alumno alumnoInv && comparable is Alumno alumnoComp)
            {
                return alumnoComp.Legajo > alumnoInv.Legajo;
            }
            return false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            if (invocador is Alumno alumnoInv && comparable is Alumno alumnoComp)
            {
                return alumnoComp.Legajo < alumnoInv.Legajo;
            }
            return false;
        }
    }
    public class EstrategiaComparacionPorLegajo : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            if (invocador is Alumno alumnoInv && comparable is Alumno alumnoComp)
            {
                return alumnoComp.Promedio == alumnoInv.Promedio;
            }
            return false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            if (invocador is Alumno alumnoInv && comparable is Alumno alumnoComp)
            {
                return alumnoComp.Promedio > alumnoInv.Promedio;
            }
            return false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            if (invocador is Alumno alumnoInv && comparable is Alumno alumnoComp)
            {
                return alumnoComp.Promedio < alumnoInv.Promedio;
            }
            return false;
        }
    }
}
