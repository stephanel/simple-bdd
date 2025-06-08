namespace SimpleBDD;

internal class ContextBase<T>(T context)
{
    protected readonly T Context = context;
}