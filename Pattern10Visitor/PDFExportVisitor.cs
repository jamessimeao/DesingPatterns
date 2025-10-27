using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern10Visitor
{
    internal class PDFExportVisitor : IVisitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            Console.WriteLine("Exporting law client as PDF");
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            Console.WriteLine("Exporting restaurant client as PDF");
        }

        public void VisitRetail(RetailClient retailClient)
        {
            Console.WriteLine("Exporting retail client as PDF");
        }
    }
}
