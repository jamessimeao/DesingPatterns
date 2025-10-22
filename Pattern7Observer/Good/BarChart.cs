using Pattern7Observer.Bad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern7Observer.Good
{
    internal class BarChart : IObserver
    {
        private DataSource _dataSource;

        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Render bar chart with new values");
        }
    }
}
