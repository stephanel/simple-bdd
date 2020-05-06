using System;

namespace SimpleBDD
{
    public class Feature<T> : IFeature<T>
    {
        T _context;
        readonly string _specTitle;

        public Feature(string specTitle)
        {
            _specTitle = specTitle;
        }

        public IFeature<T> Given(T context)
        {
            _context = context;
            return this;
        }

        public IFeature<T> Then(Action<T> action)
        {
            action.Invoke(_context);
            return this;
        }

        public IFeature<T> When(Func<T, T> action)
        {
            _context = action.Invoke(_context);
            return this;
        }

        public IFeature<T> And(Func<T, T> action)
        {
            _context = action.Invoke(_context);
            return this;
        }
    }
}
