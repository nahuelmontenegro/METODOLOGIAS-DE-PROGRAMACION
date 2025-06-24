using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.GeneradorRandom
{
    public class Generar : IGenerador
    {
        private static Random rnd = new Random(); //Única instancia de Random

        //Generar un DNI aleatorio entre 25.000.000 y 45.000.000
        public int generarDNI()
        {
            return rnd.Next(25000000, 45000000);
        }

        //Generar un número de legajo aleatorio entre 0 y 20.000
        public int generarLegajo()
        {
            return rnd.Next(0, 20000);
        }

        //Generar un nombre aleatorio a partir de una lista de nombres
        public string generarNombre()
        {
            List<string> nombresAlAzar = new List<string>
        {
            "Joseph", "Ismael", "Joaquin", "Elsa", "Carlos", "Esteban", "Raul", "Luana",
            "Beto", "Juan", "Ángel", "Santiago", "Kiko", "Dario", "Marcos", "Carmen",
            "María", "Mateo", "Jesús", "Julian", "Gino", "Gina", "Elias", "Moises",
            "Leandro", "Gonzalo", "Gabriel", "Franco", "Sergio", "Ariel", "Nehuen", "Gerardo",
            "Jeremy", "Antonio", "Rosa", "Bastian", "Julio", "André", "Roque", "Jimena",
            "Laura", "Rinaldo", "Sharon", "Rosa", "Claudia", "Hector", "Mabi", "Osvaldo",
            "Matias", "Miguel"
        };

            int indiceNombre = rnd.Next(nombresAlAzar.Count);
            return nombresAlAzar[indiceNombre];
        }

        //Generar un promedio aleatorio entre 2.0 y 10.0
        public double generarPromedio()
        {
            double promedio = Math.Round(rnd.Next(0, 10) + rnd.NextDouble(), 2);
            return promedio;
        }
    }
}
