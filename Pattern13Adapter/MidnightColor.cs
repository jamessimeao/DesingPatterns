using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern13Adapter
{
    internal class MidnightColor : Color
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying midnight-purple color to video");
        }
    }
}
