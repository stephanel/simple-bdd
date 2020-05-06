using System;

namespace SimpleBDD
{
    public class Then<T> : ContextBase<T>, IThen<T>
    {
        public Then(T context)
            : base(context)
        { }

        public IThen<T> And(Action<T> action)
        {
            action.Invoke(_context);
            return this;
        }
    }
}
