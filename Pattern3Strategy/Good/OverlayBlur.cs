using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Good
{
    internal class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying blur overlay");
        }
    }
}
