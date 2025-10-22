using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern8Mediator
{
    internal class Button : UIControl
    {
        private bool _isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
            _isEnabled = false;
        }

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            _owner.Changed(this);
        }
    }
}
