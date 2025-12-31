using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern14Bridge
{
    internal class SonyRadio : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine($"Setting Sony radio to channel {channel}.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning Sony radio off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning Sony radio on.");
        }
    }
}
