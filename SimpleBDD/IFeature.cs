using System;

namespace SimpleBDD
{
    public interface IFeature<T>
    {
        IFeature<T> Given(T context);
        IFeature<T> When(Func<T, T> action);
        IFeature<T> And(Func<T, T> action);
        IFeature<T> Then(Action<T> action);
    }
}
