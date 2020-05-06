namespace SimpleBDD
{
    public interface ISpecification<T>
    {
        IGiven<T> Given(T context);
    }
}
