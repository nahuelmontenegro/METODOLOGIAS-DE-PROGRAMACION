using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class Numero : IComparable
    {
        private int valor;

        //Constructor que recibe un valor y lo asigna a la variable valor
        public Numero(int v) 
        {
            valor = v;
        }

        //Metodo que devuelve el valor almacenado
        public int getValor()
        {
            return valor;
        }

        //Implementacion de interface IComparable
        //Se utiliza casting al numero para convertir el tipo comparable a tipo numero
        //Se podria implementar con if/else pero es redundante ya que las comparaciones ==, >, y < ya devuelven valores booleanos
        bool IComparable.sosIgual(IComparable v)
        {
            return this.getValor() == ((Numero)v).getValor();
        }

        bool IComparable.sosMenor(IComparable v)
        {
            return this.getValor() < ((Numero)v).getValor();
        }

        bool IComparable.sosMayor(IComparable v)
        {
            return this.getValor() > ((Numero)v).getValor();
        }
    }
}
