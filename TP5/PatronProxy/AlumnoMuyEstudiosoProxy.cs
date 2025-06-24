using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;

namespace TP5.PatronProxy
{
    public class AlumnoMuyEstudiosoProxy : Student, IComparableX
    {
        private AlumnoMuyEstudioso alumnoMuyEstudiosoProxy = null;
        public AlumnoMuyEstudioso ProxyAlumnoMuyEstudioso
        {
            get { return alumnoMuyEstudiosoProxy; }
            private set { alumnoMuyEstudiosoProxy = value; }
        }

        //Propiedades del proxy
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public int Legajo { get; set; }
        public double Promedio { get; set; }
        public double Calificacion { get; set; }


        public AlumnoMuyEstudiosoProxy(string nombre, int dni, int legajo, double promedio)
        {
            Nombre = nombre;
            DNI = dni;
            Legajo = legajo;
            Promedio = promedio;
            Calificacion = 1; //Calificación inicial por defecto
        }

        //Método para obtener el nombre del estudiante
        public string getName()
        {
            return Nombre;
        }
        //Método para responder una pregunta (crea el objeto real si es necesario)
        public int yourAnswerIs(int question)
        {
            if (ProxyAlumnoMuyEstudioso == null)
            {
                ProxyAlumnoMuyEstudioso = new AlumnoMuyEstudioso(Nombre, DNI, Legajo, Promedio);
                Console.WriteLine("Se crea el AlumnoMuyEstudioso Real");
            }
            return ProxyAlumnoMuyEstudioso.responderPregunta(question);
        }
        //Obtener la calificación
        public int getScore()
        {
            return (int)Calificacion;
        }

        public void setScore(int score)
        {
            Calificacion = score;
        }

        public string showResult()
        {
            return $"Alumno: {Nombre}, Calificación: {Calificacion}";
        }

        //Métodos de comparación para la interfaz Student
        public bool equals(Student student)
        {
            return Calificacion.Equals(student.getScore());
        }

        public bool lessThan(Student student)
        {
            return Calificacion < student.getScore();
        }

        public bool greaterThan(Student student)
        {
            return Calificacion > student.getScore();
        }

        // Implementación de la interfaz IComparableX
        public bool sosIgual(IComparableX comparable)
        {
            if (comparable is AlumnoMuyEstudiosoProxy other)
                return DNI == other.DNI;
            return false;
        }

        public bool sosMenor(IComparableX comparable)
        {
            if (comparable is AlumnoMuyEstudiosoProxy other)
                return DNI < other.DNI;
            return false;
        }

        public bool sosMayor(IComparableX comparable)
        {
            if (comparable is AlumnoMuyEstudiosoProxy other)
                return DNI > other.DNI;
            return false;
        }
    }
}
