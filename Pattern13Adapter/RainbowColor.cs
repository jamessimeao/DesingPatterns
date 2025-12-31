using Pattern13Adapter.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern13Adapter
{
    internal class RainbowColor : Color
    {
        private Rainbow _rainbow;
   
        public RainbowColor()
        {
            _rainbow = new Rainbow();
        }

        public void Apply(Video video)
        {
            _rainbow.Setup();
            _rainbow.Update(video);
        }
    }
}
