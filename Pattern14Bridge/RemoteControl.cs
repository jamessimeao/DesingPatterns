using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern14Bridge
{
    internal class RemoteControl
    {
        protected Device _device;

        public RemoteControl(Device device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
