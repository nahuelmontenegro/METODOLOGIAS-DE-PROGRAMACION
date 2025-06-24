using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Comparables;
using TP4.PatronObserver;

namespace TP4.PatronStrategy
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
    //Estrategia Comparacion Bonus para vendedores
    public class EstrategiaComparacionBonus : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            Vendedor vendedorInvocador = invocador as Vendedor;
            Vendedor vendedorComparable = comparable as Vendedor;

            //Verifica si ambos son Vendedores antes de compararlos
            if (vendedorInvocador != null && vendedorComparable != null)
            {
                return vendedorInvocador.Bonus.Equals(vendedorComparable.Bonus);
            }
            return false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            Vendedor vendedorInvocador = invocador as Vendedor;
            Vendedor vendedorComparable = comparable as Vendedor;

            if (vendedorInvocador != null && vendedorComparable != null)
            {
                return vendedorInvocador.Bonus < vendedorComparable.Bonus;
            }
            return false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            Vendedor vendedorInvocador = invocador as Vendedor;
            Vendedor vendedorComparable = comparable as Vendedor;

            if (vendedorInvocador != null && vendedorComparable != null)
            {
                return vendedorInvocador.Bonus > vendedorComparable.Bonus;
            }
            return false;
        }
    }
}
