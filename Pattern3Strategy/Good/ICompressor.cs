using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Good
{
    internal interface ICompressor
    {
        public void Compress();
        public string Extension();
    }
}
