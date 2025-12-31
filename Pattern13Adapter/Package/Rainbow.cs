using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern13Adapter.Package
{
    internal class Rainbow
    {
        public void Setup()
        {
            Console.WriteLine("Setting up rainbow filter.");
        }

        public void Update(Video video)
        {
            Console.WriteLine("Applying rainbow filter to video.");
        }
    }
}
