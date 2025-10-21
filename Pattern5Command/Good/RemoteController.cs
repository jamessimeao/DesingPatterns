using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern5Command.Good
{
    internal class RemoteController
    {
        private ICommand _command;

        public RemoteController(ICommand command)
        {
            _command = command;
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
