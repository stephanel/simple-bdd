using System;

namespace SimpleBDD;

public interface IWhen<T>
{
    IWhen<T> And(Func<T, T> action);
    IThen<T> Then(Action<T> action);
}

internal class When<T>(T context) : ContextBase<T>(context), IWhen<T>
{
    public IWhen<T> And(Func<T, T> action)
        => new When<T>(action.Invoke(Context));

    public IThen<T> Then(Action<T> action)
    {
        action.Invoke(Context);
        return new Then<T>(Context);
    }
}