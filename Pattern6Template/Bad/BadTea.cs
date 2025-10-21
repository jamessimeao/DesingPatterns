using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Bad
{
    internal class BadTea
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }


        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup");
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
            Console.WriteLine("Would you like lemon into your tea: y/n");
            string? answer = Console.ReadLine();
            return answer == "y";
        }
    }
}
