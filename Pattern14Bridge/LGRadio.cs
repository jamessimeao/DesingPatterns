using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern14Bridge
{
    internal class LGRadio : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine($"Setting LG radio to channel {channel}.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning LG radio off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning LG radio on.");
        }
    }
}
