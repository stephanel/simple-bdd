using System;

namespace SimpleBDD
{
    public class Then<T> : ContextBase<T>, IThen<T>
    {
        public Then(T context)
            : base(context)
        { }

        public IThen<T> And(Func<T, T> action)
        {
            _context = action.Invoke(_context);
            return this;
        }
    }
}
