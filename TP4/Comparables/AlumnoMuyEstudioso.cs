using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.PatronStrategy;

namespace TP4.Comparables
{
    public class AlumnoMuyEstudioso : Alumno
    {
        //Constructor que inicializa un AlumnoMuyEstudioso con sus datos
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio)
            : base(nombre, dni, legajo, promedio)
        {
            //Inicializa los datos heredados del Alumno y asigna una estrategia por defecto
            this.Estrategia = new EstrategiaComparacionPorNombre();
        }

        //Reimplementación del método responderPregunta
        //Siempre responde correctamente utilizando la lógica del módulo
        public new int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
