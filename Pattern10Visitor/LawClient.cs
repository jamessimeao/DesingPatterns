using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern10Visitor
{
    internal class LawClient : Client
    {
        public LawClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitLaw(this);
        }
    }
}
