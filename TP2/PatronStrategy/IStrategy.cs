using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.PatronStrategy
{
    public interface IStrategy<T>
    {
        bool sosIgual(T invocador, T comparable);
        bool sosMenor(T invocador, T comparable);
        bool sosMayor(T invocador, T comparable);
    }
}
