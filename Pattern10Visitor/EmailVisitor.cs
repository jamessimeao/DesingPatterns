using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern10Visitor
{
    internal class EmailVisitor : IVisitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            Console.WriteLine($"Sending law marketing tips to {lawClient.GetEmail()}");
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            Console.WriteLine($"Sending restaurant marketing tips to {restaurantClient.GetEmail()}");
        }

        public void VisitRetail(RetailClient retailClient)
        {
            Console.WriteLine($"Sending retail marketing tips to {retailClient.GetEmail()}");
        }
    }
}
