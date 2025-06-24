using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;
using TP5.PatronFactoryMethod;

namespace TP5.PatronAdapter
{
    public class Main
    {
        public static void Run()
        {
            //EJ 4 TP4

            Teacher maestro = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = new AdapterStudent((Alumno)new FabricaAlumno().crearAleatorio());
                maestro.goToClass(adaptado);
            }
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = new AdapterStudent((AlumnoMuyEstudioso)new FabricaAlumnoMuyEstudioso().crearAleatorio());
                maestro.goToClass(adaptado);
            }
            maestro.teachingAClass();
        }
    }
}
