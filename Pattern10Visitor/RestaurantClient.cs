using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern10Visitor
{
    internal class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRestaurant(this);
        }
    }
}
