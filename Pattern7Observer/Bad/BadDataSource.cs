using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern7Observer.Bad
{
    internal class BadDataSource
    {
        private List<int> _values = new List<int>();
        private List<object> _dependents = new List<object>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;

            foreach(var dependent in _dependents)
            {
                if(dependent is Sheet2)
                {
                    Sheet2 sheet = (Sheet2)dependent;
                    sheet.CalculateTotal(values);
                }
                else if(dependent is BarChart)
                {
                    BarChart bar = (BarChart)dependent;
                    bar.Render(values);
                }
            }
        }

        public void AddDependent(object dependent)
        {
            _dependents.Add(dependent);
        }

        public void RemoveDependent(object dependent)
        {
            _dependents.Remove(dependent);
        }
    }
}
