using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern5Command.Bad
{
    // Invoker
    internal class BadRemoteControl
    {
        private Light _light;

        public BadRemoteControl(Light light)
        {
            _light = light;
        }

        public void PressButton(bool TurnOn)
        {
            if (TurnOn)
            {
                _light.TurnOn();
            }
            else
            {
                _light.TurnOff();
            }
        }
    }
}
