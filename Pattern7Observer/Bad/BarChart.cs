using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern7Observer.Bad
{
    internal class BarChart
    {
        public void Render(List<int> values)
        {
            Console.WriteLine("Render bar chart with new values");
        }
    }
}
