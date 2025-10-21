using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern5Command.Good
{
    internal class TurnOffCommand : ICommand
    {
        private Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
