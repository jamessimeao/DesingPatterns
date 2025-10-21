using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern5Command.Good
{
    internal class DimCommand : ICommand
    {
        private Light _light;

        public DimCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
}
