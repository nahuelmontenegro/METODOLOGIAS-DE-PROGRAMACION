using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.GeneradorRandom
{
    public interface IGenerador
    {
        string generarNombre();
        int generarDNI();
        int generarLegajo();
        double generarPromedio();
    }
}
