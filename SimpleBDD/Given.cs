using System;

namespace SimpleBDD;

public interface IGiven<T>
{
    IWhen<T> When(Func<T, T> action);
}

internal class Given<T>(T context) : ContextBase<T>(context), IGiven<T>
{
    public IWhen<T> When(Func<T, T> action)
        => new When<T>(action.Invoke(Context));
}