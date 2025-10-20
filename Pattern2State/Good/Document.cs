using Pattern2State.Good.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern2State.Good
{
    internal class Document
    {
        public State State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles currentUserRole)
        {
            State = new DraftState(this);
            CurrentUserRole = currentUserRole;
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}
