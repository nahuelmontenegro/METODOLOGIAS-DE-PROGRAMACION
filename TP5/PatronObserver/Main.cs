using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Coleccionables;
using TP5.Comparables;
using TP5.GeneradorRandom;
using TP5.PatronIterator;

namespace TP5.PatronObserver
{
    public class Main
    {
        public static void Run()
        {
            Cola newCola = new Cola();
            Impresiones.Main.llenar(newCola, 5); //Se le pasa el 5 ya que es la fabrica de Vendedores
            Gerente jefe = new Gerente();
            IIterator iter = newCola.CreateIterator();
            while (!iter.EsFin())
            {
                Vendedor elemento = (Vendedor)iter.Siguiente();
                elemento.agregarObservador(jefe);
            }
            jornadaDeVentas(newCola);
            jefe.cerrar();

        }

        public static void jornadaDeVentas(IColeccionable<IComparableX> coleccion)
        {
            double monto;
            IIterator iter = coleccion.CreateIterator();
            while (!iter.EsFin())
            {
                Vendedor elemento = (Vendedor)iter.Siguiente();
                monto = new GeneradorDeDatosAleatorios().numeroAleatorio(7000);
                elemento.venta(monto);
            }
        }
    }
}
