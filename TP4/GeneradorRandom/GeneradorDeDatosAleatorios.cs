using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.GeneradorRandom
{
    public class GeneradorDeDatosAleatorios
    {
        //Instancia de Random para generar números aleatorios
        static Random rnd = new Random();

        //Método que genera un número aleatorio entre 0 y un límite especificado
        public int numeroAleatorio(int limite)
        {
            //Genera un número aleatorio entre 0 y el límite (exclusivo)
            return rnd.Next(0, limite);
        }

        //Método que genera una cadena aleatoria basada en archivos de texto
        public string stringAleatorio(int cantidadCaracteres)
        {
            //Rutas absolutas a los archivos de nombres y parentescos
            string rutaNombre = "Nombres.txt";
            string rutaParentesco = "Parentesco.txt";

            //Lee todo el contenido de los archivos en arreglos de strings
            string[] registroNombres = File.ReadAllLines(rutaNombre);
            string[] registroParentesco = File.ReadAllLines(rutaParentesco);

            //Selecciona aleatoriamente un nombre y un parentesco
            int punteroNombre = rnd.Next(0, registroNombres.Length);
            int punteroParentesco = rnd.Next(0, registroParentesco.Length);

            //Genera una palabra uniendo un parentesco y un nombre
            string palabra = registroNombres[punteroParentesco] + " " + registroNombres[punteroNombre];

            //Ajusta la longitud de la palabra al tamaño especificado
            //Si la longitud no coincide, se vuelve a generar una nueva combinación
            while (!palabra.Length.Equals(cantidadCaracteres))
            {
                //Selecciona un nuevo nombre y parentesco aleatoriamente
                punteroNombre = rnd.Next(0, registroNombres.Length);
                punteroParentesco = rnd.Next(0, registroParentesco.Length);

                //Genera una nueva combinación
                palabra = registroParentesco[punteroParentesco] + " " + registroNombres[punteroParentesco];
            }

            //Devuelve la cadena generada con la longitud deseada
            return palabra;
        }
    }
}
