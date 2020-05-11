namespace SimpleBDD
{
    public class Specification<T> : ISpecification<T>
    {
        T _context;

        public Specification()
        { }

        public IGiven<T> Given(T context)
        {
            _context = context;
            return new Given<T>(_context);
        }
    }
}
