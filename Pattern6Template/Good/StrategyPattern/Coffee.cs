using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Good.StrategyPattern
{
    internal class Coffee : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding cream to the coffee");
            }
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like cream with your coffee: y/n");
            string? answer = Console.ReadLine();
            return answer == "y";
        }
    }
}
