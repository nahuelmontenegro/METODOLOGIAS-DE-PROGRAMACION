using System;
using System.IO;
namespace TP
{
    public class Main
    {
        public static void RunTP()
        {
            Pila pila = new Pila();
            Cola cola = new Cola();

            llenarAlumnos(pila);
            llenarAlumnos(cola);
            //Crear ColeccionMultiple que contenga la pila y la cola
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            informar(multiple); //Informa cola y pila

        }

        static void llenar(IColeccionable coleccionable)
        {
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                int valorAleatorio = rnd.Next(1, 101);
                IComparable comparable = new Numero(valorAleatorio);
                //Agrego el objeto comparable a la coleccion
                coleccionable.agregar(comparable);
            }
        }

        static void informar(ColeccionMultiple coleccionable)
        {
            Console.Clear();
            //Mostrar la cantidad total de elementos en la colección múltiple
            Console.WriteLine("La Cantidad total de elementos en la colección múltiple es: " + coleccionable.cuantos());

            //Mostrar la persona con el DNI más bajo | podria ser el mas alto, es por el ej.
            Persona personaConDniMasBajo = (Persona)coleccionable.minimo();
            Console.WriteLine("La persona con DNI más bajo es: " + personaConDniMasBajo.getNombre());
            Console.WriteLine("Su DNI es: " + personaConDniMasBajo.getDNI());
            Console.WriteLine("Y su Legajo es: " + ((Alumno)personaConDniMasBajo).getLegajo());

            Console.WriteLine("Por favor, ingresar un DNI para ver si está en la coleccion: ");
            int DNIpedido = Convert.ToInt32(Console.ReadLine());
            Alumno newAlumno = new Alumno("alumno", DNIpedido, 1, 1);
            if (coleccionable.contiene(newAlumno))
            {
                Console.WriteLine("El elemento leido SI está en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leído NO está en la colección");
            }
        }
        //EJ 12
        static void llenarPersonas(IColeccionable coleccionable)
        {
            Random rnd = new Random();
            string[] nombresAleatorios = { "Juan", "Matias", "Pedro", "Denise", "Enzo", "Marta", "Luis", "Sofía", "Roberto", "Vilma" };

            for (int i = 0; i < 20; i++)
            {
                //Generar un nombre al azar de la lista de nombres
                string nombre = nombresAleatorios[rnd.Next(nombresAleatorios.Length)];
                int dni = rnd.Next(5000000, 50000000);
                // Crear una nueva persona con los valores aleatorios
                IComparable persona = new Persona(nombre, dni);
                // Agregar la persona al coleccionable
                coleccionable.agregar(persona);
            }
        }
        //EJ 16 
        static void llenarAlumnos(IColeccionable coleccionable)
        {
            Random rnd = new Random();
            string[] nombresAleatorios = { "Juan", "Matias", "Pedro", "Denise", "Enzo", "Marta", "Luis", "Sofía", "Roberto", "Vilma" };

            for (int i = 0; i < 20; i++)
            {
                string nombre = nombresAleatorios[rnd.Next(nombresAleatorios.Length)];
                int dni = rnd.Next(5000000, 50000000);
                int legajo = rnd.Next(10000, 20000);
                int promedio = rnd.Next(1, 10);
                // Crear un nuevo alumno con los valores aleatorios
                IComparable alumno = new Alumno(nombre, dni, legajo, promedio);
                coleccionable.agregar(alumno);
            }
        }
    }
}
//EJ 14
//Ademas de la creacion de la nueva clase Persona, la creacion de la Funcion llenarPersonas y la adaptacion del modulo main modifique:
//Antes lo enfoque como para comparar solo numeros, de igual en lugar de hacer cast a Numero y usar getValor(), utilize ToString() para imprimir el valor del elemento. de esta manera es mas generico el elemento. Ademas llenaba pila y cola por indivudualmente para mostrar elementos por separado*/

