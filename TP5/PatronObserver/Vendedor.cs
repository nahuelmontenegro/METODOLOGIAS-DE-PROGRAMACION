using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;
using TP5.PatronStrategy;

namespace TP5.PatronObserver
{
    public class Vendedor : Persona, IComparableX, IObservado
    {
        private double sueldoBasico;
        private double bonus;
        private double ultimaVenta = 0;
        private List<IObservador> listaObservadores;

        public double SueldoBasico { get { return sueldoBasico; } set { sueldoBasico = value; } }
        public double Bonus { get { return bonus; } set { bonus = value; } }

        public double UltimaVenta { get { return ultimaVenta; } set { ultimaVenta = value; } }

        public List<IObservador> ListaObservadores { get { return listaObservadores; } set { listaObservadores = value; } }

        public Vendedor(string nombre, int dni, double suedoBasico)
        {
            base.Nombre = nombre;
            base.DNI = dni;
            this.SueldoBasico = suedoBasico;
            this.Bonus = 1;
            this.ListaObservadores = new List<IObservador>();
            base.Estrategia = new EstrategiaComparacionBonus();
        }

        public void venta(double monto)
        {
            this.UltimaVenta = monto;
            Console.WriteLine("El vendedor {0} ha concretado una venta por un valor de {1}.", this.Nombre, monto);
            notificar();

        }

        public void aumentaBonus()
        {
            this.Bonus += 0.1;
        }

        public void agregarObservador(IObservador observador)
        {
            ListaObservadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            ListaObservadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (IObservador observador in ListaObservadores)
            {
                observador.actualizar(this);
            }
        }
    }
}
