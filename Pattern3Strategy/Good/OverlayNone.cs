using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Good
{
    internal class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Not applying overlay");
        }
    }
}
