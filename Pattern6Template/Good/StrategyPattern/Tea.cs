using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Good.StrategyPattern
{
    internal class Tea : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments()
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
