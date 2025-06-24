using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;
using TP5.PatronAdapter;

namespace TP5.PatronCommand
{
    public class Aula
    {
        private Teacher teacher;
        public Teacher Profesor { get; set; }

        public void comenzar()
        {
            Console.WriteLine("Se instancia al Profesor. ");
            Profesor = new Teacher();
        }

        public void nuevoAlumno(Alumno estudiante)
        {
            AdapterStudent adaptado = new AdapterStudent(estudiante);
            Profesor.goToClass(adaptado);
        }

        public void claseLista()
        {
            Profesor.teachingAClass();
        }
    }
}
