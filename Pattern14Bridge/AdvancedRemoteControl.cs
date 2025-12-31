using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern14Bridge
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }

        public void SetChannel(int channel)
        {
            _device.SetChannel(channel);
        }
    }
}
