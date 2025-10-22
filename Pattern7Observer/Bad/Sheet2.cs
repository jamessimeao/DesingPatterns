using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern7Observer.Bad
{
    internal class Sheet2
    {
        /*
        private int _total;

        public int GetTotal()
        {
            return _total;
        }
        */

        public int CalculateTotal(List<int> values)
        {
            int sum = 0;
            foreach(int value in values){
                sum += value;
            }
            Console.WriteLine($"Total: {sum}");
            return sum;
        }
    }
}
