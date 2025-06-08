using System;

namespace SimpleBDD;

public interface IThen<out T>
{
    IThen<T> And(Action<T> action);
}

internal class Then<T>(T context) : ContextBase<T>(context), IThen<T>
{
    public IThen<T> And(Action<T> action)
    {
        action.Invoke(Context);
        return new Then<T>(Context);
    }
}