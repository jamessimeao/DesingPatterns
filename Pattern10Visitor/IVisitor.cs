using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern10Visitor
{
    internal interface IVisitor
    {
        public void VisitRetail(RetailClient retailClient);
        public void VisitLaw(LawClient lawClient);
        public void VisitRestaurant(RestaurantClient restaurantClient);
    }
}
