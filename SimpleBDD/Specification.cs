namespace SimpleBDD
{
    public class Specification<T> : ISpecification<T>
    {
        T _context;
        readonly string _specTitle;

        public Specification(string specTitle)
        {
            _specTitle = specTitle;
        }

        public IGiven<T> Given(T context)
        {
            _context = context;
            return new Given<T>(_context);
        }
    }
}
