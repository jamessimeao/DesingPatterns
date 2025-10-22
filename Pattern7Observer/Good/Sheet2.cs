using Pattern7Observer.Bad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern7Observer.Good
{
    internal class Sheet2 : IObserver
    {
        private int _total;
        private DataSource _dataSource;

        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public int GetTotal()
        {
            return _total;
        }

        private int CalculateTotal(List<int> values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            Console.WriteLine($"Total: {sum}");
            return sum;
        }

        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }
    }
}
