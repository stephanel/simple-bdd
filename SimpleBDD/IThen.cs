using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBDD
{
    public interface IThen<T>
    {
        IThen<T> And(Func<T, T> action);
    }
}
