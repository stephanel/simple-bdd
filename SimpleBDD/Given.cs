using System;

namespace SimpleBDD
{
    public class Given<T> : ContextBase<T>, IGiven<T>
    {
        public Given(T context)
            : base(context)
        { }

        public IWhen<T> When(Func<T, T> action)
        {
            _context = action.Invoke(_context);
            return new When<T>(_context);
        }
    }
}
