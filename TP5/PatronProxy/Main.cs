using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.PatronFactoryMethod;

namespace TP5.PatronProxy
{
    public class Main
    {
        public static void Run()
        {
            //EJ 8 TP 4
            //Reingenieria para que cree alumnos proxys

            Teacher maestro = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
                maestro.goToClass(adaptado);
            }
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = (AlumnoMuyEstudiosoProxy)new FabricaAlumnoMuyEstudiosoProxy().crearAleatorio();
                maestro.goToClass(adaptado);
            }

            maestro.teachingAClass();
        }
    }
}
