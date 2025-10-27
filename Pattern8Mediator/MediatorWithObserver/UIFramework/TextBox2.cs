using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern8Mediator.MediatorWithObserver.UIFramework
{
    internal class TextBox2 : UIControl2
    {
        private string _text = "";

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
            NotifyEventHandlers();
        }
    }
}
