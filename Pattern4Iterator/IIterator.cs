using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern4Iterator
{
    internal interface IIterator<T>
    {
        public T Current();
        public bool HasNext();
        public void Next();
    }
}
