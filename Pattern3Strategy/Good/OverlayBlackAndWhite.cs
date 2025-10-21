using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Good
{
    internal class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying black and white overlay");
        }
    }
}
