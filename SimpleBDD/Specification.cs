namespace SimpleBDD;

public static class Specification
{
    public static IGiven<T> Given<T>(T context) => new Given<T>(context);
}