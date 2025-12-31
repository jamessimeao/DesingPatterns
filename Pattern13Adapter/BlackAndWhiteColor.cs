using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern13Adapter
{
    internal class BlackAndWhiteColor : Color
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying black and white color to video.");
        }
    }
}
