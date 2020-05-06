using System;

namespace SimpleBDD
{
    public interface IWhen<T>
    {
        IWhen<T> And(Func<T, T> action);
        IThen<T> Then(Action<T> action);
    }
}
