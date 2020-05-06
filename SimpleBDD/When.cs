using System;

namespace SimpleBDD
{
    public class When<T> : ContextBase<T>, IWhen<T>
    {
        public When(T context)
            : base(context)
        { }

        public IWhen<T> And(Func<T, T> action)
        {
            _context = action.Invoke(_context);
            return this;
        }

        public IThen<T> Then(Action<T> action)
        {
            action.Invoke(_context);
            return new Then<T>(_context);
        }
    }
}
