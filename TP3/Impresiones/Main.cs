using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using TP3.Coleccionables;
using TP3.Comparables;
using TP3.GeneradorRandom;
using TP3.PatronStrategy;
using TP3.PatronIterator;
using TP3.PatronFactoryMethod;
using TP3.PatronObserver;

namespace TP3.Impresiones
{
    public class Main
    {
        public static void Run()
        {
            Cola colaPersonas = new Cola();
            Cola colaAlumnos = new Cola();
            Pila pilaPersonas = new Pila();
            Pila pilaAlumnos = new Pila();

            llenarAlumnos(colaAlumnos);
            llenarAlumnos(pilaAlumnos);
            llenarPersonas(pilaPersonas);
            llenarPersonas(colaPersonas);

            ColeccionMultiple ColeccionMultuplePersonas = new ColeccionMultiple(pilaPersonas, colaPersonas);
            ColeccionMultiple ColeccionMultupleAlumnos = new ColeccionMultiple(pilaAlumnos, colaAlumnos);

            informarPersonas(ColeccionMultuplePersonas);
            informarPersonas(ColeccionMultupleAlumnos);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tPila y Cola de Personas:\n");
            Console.ForegroundColor = ConsoleColor.White;
            informarPersonas(ColeccionMultuplePersonas);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tPila y Cola de Alumnos:\n");
            Console.ForegroundColor = ConsoleColor.White;
            informarPersonas(ColeccionMultupleAlumnos);
        }

        public static void Run2()
        {
            //Ejercicio 8
            Pila newPila = new Pila();
            Cola newCola = new Cola();
            Conjunto newConjunto = new Conjunto();
            Diccionario newDiccionario = new Diccionario();

            llenarAlumnos(newPila);
            llenarAlumnos(newCola);
            llenarAlumnos(newConjunto);
            llenarAlumnos(newDiccionario);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tPila: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementos(newPila);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tCola: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementos(newCola);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tConjunto: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementos(newConjunto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tDiccionario: ");
            Console.ForegroundColor = ConsoleColor.White;
            PatronIterator.Main.imprimirElementos(newDiccionario);
        }

        public static void Run3()
        {	//EJ 10
            Pila newPila = new Pila();
            llenarAlumnos(newPila);
            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorNombre());
            informar(newPila);

            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorDNI());
            informar(newPila);

            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorLegajo());
            informar(newPila);

            PatronStrategy.Main.cambioEstrategia(newPila, new EstrategiaComparacionPorPromedio());
            informar(newPila);
            //Para tener validación de 20 objetos, se debe comentar las 2 líneas Siguientes
            Console.WriteLine();
            PatronIterator.Main.imprimirElementos(newPila);
        }
        public static void Run4()
        {	//EJ 6 
            Pila newPila = new Pila();
            Console.Clear();
            Console.WriteLine("\t1) Persona. \n" +
                              "\t2) Alumno. \n" +
                              "\t3) Numero. \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tPor favor, ingrese que tipo de Comparable desea crear para llenar la Pila: ");
            Console.ForegroundColor = ConsoleColor.White;
            int eleccionP = new LecturaDeDatos().numeroPorTeclado();
            llenar(newPila, eleccionP);
            //Llenar Cola
            Cola newCola = new Cola();
            Console.Clear();
            Console.WriteLine("\t1) Persona. \n" +
                              "\t2) Alumno. \n" +
                              "\t3) Numero. \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Por favor, ingrese que tipo de Comparable desea crear para llenar la Cola: ");
            Console.ForegroundColor = ConsoleColor.White;
            int eleccionC = new LecturaDeDatos().numeroPorTeclado();
            llenar(newCola, eleccionC);
            //Llenar Conjunto
            Conjunto newConjunto = new Conjunto();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t1) Persona. \n" +
                              "\t2) Alumno. \n" +
                              "\t3) Numero. \n");
            Console.Write("\tPor favor, ingrese que tipo de Comparable desea crear para llenar el Conjunto: ");
            Console.ForegroundColor = ConsoleColor.White;
            int eleccionCJ = new LecturaDeDatos().numeroPorTeclado();
            llenar(newConjunto, eleccionCJ);
            //Llenar Diccionario;
            Diccionario newDiccionario = new Diccionario();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t1) Persona. \n" +
                              "\t2) Alumno. \n" +
                              "\t3) Numero. \n");
            Console.Write("\tPor favor, ingrese que tipo de Comparable desea crear para llenar el Diccionario: ");
            Console.ForegroundColor = ConsoleColor.White;
            int eleccionD = new LecturaDeDatos().numeroPorTeclado();
            llenar(newDiccionario, eleccionD);

            Console.Clear();
            informar(newPila, eleccionP);
            Console.ReadKey();

            Console.Clear();
            informar(newCola, eleccionC);
            Console.ReadKey();

            Console.Clear();
            informar(newConjunto, eleccionCJ);
            Console.ReadKey();
        }

        public static void informarPersonas(ColeccionMultiple inColeccionable)
        {
            Persona minimo = (Persona)inColeccionable.minimo();
            Persona maximo = (Persona)inColeccionable.maximo();
            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos() + "\n" +
                              "La cantidad de elementos que existen en la Pila son: " + inColeccionable.cuantos() + "\n" +
                              "La Persona con menor numero de DNI entre la Cola y la Pila es: " + minimo.DNI + "\n" +
                              "La Persona con mayor numero de DNI entre la Cola y la Pila es: " + maximo.DNI
                             );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
            Console.ForegroundColor = ConsoleColor.White;
            int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario", input);
            newElemento.Estrategia = new EstrategiaComparacionPorDNI();
            if (inColeccionable.contiene(newElemento))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEl elemento leido esta en la coleccion");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void llenarAlumnos(IColeccionable<IComparableX> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 5; i++)
            {
                Alumno unAlumno = new Alumno(generar.generarNombre(), generar.generarDNI(), generar.generarLegajo(), generar.generarPromedio());
                coleccion.agregar(unAlumno);
            }
        }
        public static void llenarAlumnosDiccionario(IColeccionable<ClaveValor> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Alumno unAlumno = new Alumno(generar.generarNombre(), generar.generarDNI(), generar.generarLegajo(), generar.generarPromedio());
                ((Diccionario)coleccion).agregar(unAlumno);
            }
        }
        public static void llenarPersonas(IColeccionable<IComparableX> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Persona unaPersona = new Persona(generar.generarNombre(), generar.generarDNI());
                coleccion.agregar(unaPersona);
            }
        }
        //EJ 10 TP2
        public static void informar(IColeccionable<IComparableX> coleccion)
        {
            Alumno maximo = (Alumno)coleccion.maximo();
            Alumno minimo = (Alumno)coleccion.minimo();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tElementos de la Coleccion:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tMaximo:\n\t\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}\n" +
                "\tMinimo:\n\t\tAlumno: {4}\tDNI: {5}\tLegajo: {6}\tPromedio: {7}",
                     maximo.Nombre, maximo.DNI, maximo.Legajo, maximo.Promedio,
                     minimo.Nombre, minimo.DNI, minimo.Legajo, minimo.Promedio);
        }
        //EJ 6 TP 3
        public static void llenar(IColeccionable<IComparableX> coleccion, int eleccion)
        {
            FabricaDeComparables<IComparableX> fabrica;

            switch (eleccion)
            {
                case 1:
                    fabrica = (FabricaDeComparables<IComparableX>) new FabricaPersona(); //Llenar con Personas
                    break;
                case 2:
                    fabrica = (FabricaDeComparables<IComparableX>) new FabricaAlumno(); //Llenar con Alumnos
                    break;
                case 3:
                    fabrica = (FabricaDeComparables<IComparableX>) new FabricaNumero(); //Llenar con Números
                    break;
                case 4: 
                    fabrica = (FabricaDeComparables<IComparableX>) new FabricaClaveValor(); //Llenar con ClaveValor
                    break;
                case 5:
                    fabrica = (FabricaDeComparables<IComparableX>)new FabricaProfesor(); //Llenar con Profesores
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    return;
            }

            for (int i = 0; i < 20; i++)
            {
                coleccion.agregar(fabrica.crearAleatorio());
            }
        }
        public static void informar(IColeccionable<IComparableX> coleccion, int opcion)
        {
            switch (opcion)
            {
                //Caso Persona
                case 1:
                    Persona maximoPersona = (Persona)coleccion.maximo();
                    Persona minimoPersona = (Persona)coleccion.minimo();
                    Console.WriteLine("Cantidad de Elementos de la Colección: {0}\n" +
                                      "Máximo:\n\tNombre: {1}\tDNI: {2}\n" +
                                      "Mínimo:\n\tNombre: {3}\tDNI: {4}",
                                      coleccion.cuantos(),
                                      maximoPersona.Nombre, maximoPersona.DNI,
                                      minimoPersona.Nombre, minimoPersona.DNI);
                    Console.Write("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
                    int input = new LecturaDeDatos().numeroPorTeclado();
                    Persona newElemento = new Persona("Usuario", input);
                    newElemento.Estrategia = new EstrategiaComparacionPorDNI();
                    if (coleccion.contiene(newElemento))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                //Caso Alumno
                case 2:
                    Alumno maximoAlumno = (Alumno)coleccion.maximo();
                    Alumno minimoAlumno = (Alumno)coleccion.minimo();
                    Console.WriteLine("Cantidad de Elementos de la Colección: {0}\n" +
                             "Máximo:\n\tAlumno: {1}\tDNI: {2}\tLegajo: {3}\tPromedio: {4}\n" +
                             "Mínimo:\n\tAlumno: {5}\tDNI: {6}\tLegajo: {7}\tPromedio: {8}",
                             coleccion.cuantos(),
                             maximoAlumno.Nombre, maximoAlumno.DNI, maximoAlumno.Legajo, maximoAlumno.Promedio,
                             minimoAlumno.Nombre, minimoAlumno.DNI, minimoAlumno.Legajo, minimoAlumno.Promedio);
                    Console.Write("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
                    input = new LecturaDeDatos().numeroPorTeclado();
                    newElemento = new Persona("Usuario", input);
                    newElemento.Estrategia = new EstrategiaComparacionPorDNI();
                    if (coleccion.contiene(newElemento))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nEl elemento leido no se{ encuentra en la coleccion");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                //Caso Numero
                case 3:
                    Numero maximoNumero = (Numero)coleccion.maximo();
                    Numero minimoNumero = (Numero)coleccion.minimo();
                    Console.WriteLine("Cantidad de Elementos de la Colección: {0}\n" +
                              "Máximo:\n\tNúmero: {1}\n" +
                              "Mínimo:\n\tNúmero: {2}\n",
                              coleccion.cuantos(),
                              maximoNumero.Valor, minimoNumero.Valor);
                    Console.Write("\nPor favor, ingrese un Numero para saber si se encuentra dentro de la coleccion: ");
                    input = new LecturaDeDatos().numeroPorTeclado();
                    Numero newElementoNumero = new Numero(input);

                    if (coleccion.contiene(newElementoNumero))
                        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                    else
                        Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                    break;
            }
        }
        public static void Run5()
        {
            //Crear una colección para almacenar profesores
            Pila profesores = new Pila();

            //Llenar profesores
            llenarProfesores(profesores);

            //Informar sobre profesores
            informarProfesores(profesores, 1);
        }
        public static void informarProfesores(IColeccionable<IComparableX> coleccion, int opcion)
        {
            if (opcion == 1) //Caso para profesores
            {
                IIterator iterador = coleccion.CreateIterator();

                while (!iterador.EsFin())
                {
                    Profesor profesor = (Profesor)iterador.Siguiente();
                    Console.WriteLine($"Profesor: {profesor.Nombre}, DNI: {profesor.DNI}, Antigüedad: {profesor.Antiguedad}");
                }
            }
        }
        public static void llenarProfesores(IColeccionable<IComparableX> coleccion)
        {
            Random random = new Random(); //Generador de números aleatorios
            List<string> nombres = new List<string> //Lista de nombres predefinidos
                {"Carlos","Juan","Andrés","Pedro","Miguel" };

            for (int i = 0; i < 5; i++) //Generar 5 profesores
            {
                Profesor profesor = new Profesor(
                    nombres[random.Next(nombres.Count)], //Nombre aleatorio de la lista
                    random.Next(25000000, 45000000),    //Generar un DNI aleatorio
                    random.Next(1, 21)                  //Antigüedad aleatoria (1-20)
                );

                coleccion.agregar(profesor); //Agregar el profesor a la colección
            }
        }
    }
}

//EJ 7 TP 3
//El uso de interfaces, como IColeccionable<T>, permite definir un contrato común para todas las colecciones.Esto asegura que el método main pueda interactuar con cualquier tipo de colección sin preocuparse por su implementación específica.
//El objeto coleccion puede ser instanciado como una pila, cola, conjunto, etc., siempre que implementen IColeccionable.
//El método llenar debe ser capaz de trabajar con cualquier colección que implemente la interfaz IColeccionable. La implementación ya debería estar preparada para manejar diferentes tipos de comparables.
//Si se desea añadir comportamientos específicos a ciertas colecciones, se puede utilizar el Patrón Decorator. Esto permite agregar funcionalidades como conteo extra, filtros, etc., sin modificar las clases base.

