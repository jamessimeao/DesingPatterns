using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern8Mediator
{
    internal class TextBox : UIControl
    {
        private string _text = "";

        public TextBox(DialogBox owner) : base(owner)
        {

        }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
            _owner.Changed(this);
        }
    }
}
