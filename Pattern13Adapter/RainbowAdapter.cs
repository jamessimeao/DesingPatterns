using Pattern13Adapter.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern13Adapter
{
    internal class RainbowAdapter : Rainbow, Color
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video);
        }
    }
}
