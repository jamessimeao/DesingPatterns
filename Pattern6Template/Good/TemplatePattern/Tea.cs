using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Good.TemplatePattern
{
    internal class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }

        protected override void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding lemon to the tea");
            }
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea: y/n");
            string? answer = Console.ReadLine();
            return answer == "y";
        }
    }
}
