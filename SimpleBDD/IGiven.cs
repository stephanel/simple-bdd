using System;

namespace SimpleBDD
{
    public interface IGiven<T>
    {
        IWhen<T> When(Func<T, T> action);
    }
}
