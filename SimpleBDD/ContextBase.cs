using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBDD
{
    public class ContextBase<T>
    {
        protected T _context;

        public ContextBase(T context)
        {
            _context = context;
        }
    }
}
