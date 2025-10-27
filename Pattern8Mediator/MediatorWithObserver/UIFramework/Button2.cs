using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern8Mediator.MediatorWithObserver.UIFramework
{
    internal class Button2 : UIControl2
    {
        private bool _isEnabled;

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            NotifyEventHandlers();
        }

    }
}
