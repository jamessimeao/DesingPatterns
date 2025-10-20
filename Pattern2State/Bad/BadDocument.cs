using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern2State.Bad
{
    internal class BadDocument
    {
        public DocumentStates State { get; set; }
        public UserRoles CurrentUserRole {  get; set; }

        public void Publish()
        {
            switch (State)
            {
                case (DocumentStates.Draft):
                    State = DocumentStates.Moderation;
                    break;
                case (DocumentStates.Moderation):
                    if(CurrentUserRole == UserRoles.Admin)
                    {
                        State = DocumentStates.Published;
                    }
                    break;
                case (DocumentStates.Published):
                    break;
            }
        }
    }
}
