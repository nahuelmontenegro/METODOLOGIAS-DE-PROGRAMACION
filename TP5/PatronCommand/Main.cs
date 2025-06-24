using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Coleccionables;

namespace TP5.PatronCommand
{
    public class Main
    {
        public static void Run()
        {
            Cola almacenamiento = new Cola();
            Aula clase = new Aula();

            //Configurar las órdenes en el Aula
            almacenamiento.setOrdenAulaLlena(new OrdenAulaLlena(clase));
            almacenamiento.setOrdenLlegaAlumno(new OrdenLlegaAlumno(clase));
            almacenamiento.setOrdenInicio(new OrdenInicio(clase));

            //Llenar la cola con Alumnos (tipo 2) y AlumnosMuyEstudiosos (tipo 6)
            Impresiones.Main.llenar(almacenamiento, 2); //Llenar con Alumno
            Impresiones.Main.llenar(almacenamiento, 6); //Llenar con AlumnoMuyEstudioso

            //Mostrar la información de los alumnos almacenados
            Impresiones.Main.informar(almacenamiento);
        }
    }
}
