using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Good.StrategyPattern
{
    internal class BeverageMaker
    {
        private IBeverage _beverage;

        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup");
        }

        public void MakeBeverage()
        {
            // Common operations
            BoilWater();
            PourWaterIntoCup();
            // Unique operations
            _beverage.Prepare();
        }
    }
}
