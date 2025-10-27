using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern8Mediator.MediatorWithObserver.UIFramework
{
    internal class ListBox2 : UIControl2
    {
        private string _selection = "";

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(string selection)
        {
            _selection = selection;
            NotifyEventHandlers();
        }
    }
}
