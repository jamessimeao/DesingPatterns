using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern6Template.Good.TemplatePattern
{
    internal abstract class Beverage
    {
        public void Prepare()
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

        protected abstract void Brew();

        protected virtual void AddCondiments() { }
    }
}
