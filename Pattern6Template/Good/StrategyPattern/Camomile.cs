using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Good.StrategyPattern
{
    internal class Camomile : IBeverage
    {
        public void Prepare()
        {
            Brew();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing camomile for 3 minutes");
        }
    }
}
