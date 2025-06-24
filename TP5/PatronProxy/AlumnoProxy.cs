using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TP5.Comparables;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP5.PatronProxy
{
    public class AlumnoProxy : Student, IComparableX
    {
        //Campo privado para el objeto real
        private Alumno alumnoproxy = null;
        public Alumno ProxyAlumno { get { return alumnoproxy; } private set { alumnoproxy = value; } }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public int Legajo { get; set; }
        public double Promedio { get; set; }
        public double Calificacion { get; set; }


        public AlumnoProxy(string nombre, int dni, int legajo, double promedio)
        {
            Nombre = nombre;
            DNI = dni;
            Legajo = legajo;
            Promedio = promedio;
            Calificacion = 1; //Calificación inicial

        }

        //Método para obtener el nombre del estudiante
        public string getName()
        {
            return Nombre;
        }

        //Método para responder una pregunta y crear el objeto real si es necesario
        public int yourAnswerIs(int question)
        {
            if (ProxyAlumno == null)
            {
                ProxyAlumno = new Alumno(Nombre, DNI, Legajo, Promedio);
                Console.WriteLine("Se crea el Alumno Real");
            }
            return ProxyAlumno.responderPregunta(question);
        }

        //Obtener y establecer la calificación
        public int getScore()
        {
            return (int)Calificacion;
        }

        //Mostrar el resultado del examen
        public void setScore(int score)
        {
            Calificacion = score;
        }

        public string showResult()
        {
            return this.Nombre + "\t" + this.Calificacion;
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

        //Implementación de IComparableX
        public bool sosIgual(IComparableX comparable)
        {
            if (comparable is AlumnoProxy other)
                return DNI == other.DNI;
            return false;
        }

        public bool sosMenor(IComparableX comparable)
        {
            if (comparable is AlumnoProxy other)
                return DNI < other.DNI;
            return false;
        }

        public bool sosMayor(IComparableX comparable)
        {
            if (comparable is AlumnoProxy other)
                return DNI > other.DNI;
            return false;
        }
    }
}
