using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern5Command.Good
{
    internal class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
