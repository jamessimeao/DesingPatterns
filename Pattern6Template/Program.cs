using Pattern6Template.Bad;
using Pattern6Template.Good.TemplatePattern;

namespace Pattern6Template
{
    internal class Program
    {
        public static void Main()
        {
            //Bad();
            //GoodStrategyPattern();
            GoodTemplatePattern();
        }

        public static void Bad()
        {
            BadTea tea = new BadTea();
            tea.MakeBeverage();
        }

        public static void GoodStrategyPattern()
        {
            Good.StrategyPattern.BeverageMaker maker = 
                new Good.StrategyPattern.BeverageMaker(new Good.StrategyPattern.Tea());
            maker.MakeBeverage();

            maker.SetBeverage(new Good.StrategyPattern.Coffee());
            maker.MakeBeverage();

            maker.SetBeverage(new Good.StrategyPattern.Camomile());
            maker.MakeBeverage();
        }

        public static void GoodTemplatePattern()
        {

            Good.TemplatePattern.Tea tea = new Good.TemplatePattern.Tea();
            tea.Prepare();

            Good.TemplatePattern.Camomile camomile = new Good.TemplatePattern.Camomile();
            camomile.Prepare();
        }
    }
}