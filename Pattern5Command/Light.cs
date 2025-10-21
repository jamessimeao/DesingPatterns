using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern5Command
{
    // Receiver
    internal class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }

        public void Dim()
        {
            Console.WriteLine("Light is dim");
        }
    }
}
