using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern10Visitor
{
    internal class RetailClient : Client
    {
        public RetailClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRetail(this);
        }
    }
}
