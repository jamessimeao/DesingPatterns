using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern14Bridge
{
    internal interface Device
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channel);
    }
}
