using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Good.TemplatePattern
{
    internal class Camomile : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing camomile for 3 minutes");
        }
    }
}
