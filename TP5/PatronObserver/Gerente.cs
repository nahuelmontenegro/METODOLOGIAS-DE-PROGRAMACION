using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.PatronObserver
{
    public class Gerente : IObservador
    {
        private List<Vendedor> mejoresVendedores = new List<Vendedor>();
        public List<Vendedor> MejoresVendedores { get { return mejoresVendedores; } set { mejoresVendedores = value; } }
        public Gerente()
        {
            MejoresVendedores = new List<Vendedor>();
        }

        public void cerrar()
        {
            Console.WriteLine("\nLista de los Mejores Vendedores:");
            foreach (Vendedor vendedor in mejoresVendedores)
            {
                Console.WriteLine("{0} sumó un bonus de: {1}.", vendedor.Nombre, vendedor.Bonus);
            }
        }

        public void venta(double monto, Vendedor vendedor)
        {
            if (monto > 5000 && !mejoresVendedores.Contains(vendedor))
            {
                mejoresVendedores.Add(vendedor);
                vendedor.aumentaBonus();
            }
        }
        public void actualizar(IObservado observado)
        {
            Vendedor vendedorObservado = (Vendedor)observado;
            venta(vendedorObservado.UltimaVenta, vendedorObservado);
        }
    }
}
