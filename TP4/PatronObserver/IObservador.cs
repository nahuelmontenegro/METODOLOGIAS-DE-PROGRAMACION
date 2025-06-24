﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.PatronObserver
{
    public interface IObservador
    {
        void actualizar(IObservado observado);
    }
}
