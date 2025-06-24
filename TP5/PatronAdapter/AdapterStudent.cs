using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;

namespace TP5.PatronAdapter
{
    public class AdapterStudent : Student
    {
        //Campo privado para el alumno adaptado
        private Alumno adaptado;

        //Propiedad para acceder al alumno adaptado
        public Alumno Adaptado
        {
            get { return adaptado; }
            set { adaptado = value; }
        }

        //Constructor que recibe un objeto Alumno y lo adapta
        public AdapterStudent(Alumno inAlumno)
        {
            Adaptado = inAlumno;
        }

        //Implementación del método equals para comparar calificaciones
        public bool equals(Student student)
        {
            return Adaptado.Calificacion.Equals(student.getScore());
        }

        //Obtener el nombre del alumno adaptado
        public string getName()
        {
            return Adaptado.Nombre;
        }

        //Obtener la calificación del alumno adaptado
        public int getScore()
        {
            return (int)Adaptado.Calificacion;
        }

        //Comparar si el alumno adaptado tiene una calificación mayor que otro estudiante
        public bool greaterThan(Student student)
        {
            return Adaptado.Calificacion > student.getScore();
        }

        //Comparar si el alumno adaptado tiene una calificación menor que otro estudiante
        public bool lessThan(Student student)
        {
            return Adaptado.Calificacion < student.getScore();
        }

        //Establecer la calificación para el alumno adaptado
        public void setScore(int score)
        {
            Adaptado.Calificacion = score;
        }

        //Mostrar el resultado de la calificación del alumno adaptado
        public string showResult()
        {
            return Adaptado.mostrarCalificacion();
        }

        //Método para que el alumno responda a una pregunta (usando la lógica de `Alumno`)
        public int yourAnswerIs(int question)
        {
            return Adaptado.responderPregunta(question);
        }
    }
}
