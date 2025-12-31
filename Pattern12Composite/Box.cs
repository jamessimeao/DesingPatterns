using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern12Composite
{
    internal class Box : Item
    {
        private List<Item> _items = new List<Item>();

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public float GetPrice()
        {
            float total = 0;
            foreach(Item item in _items)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }
}
