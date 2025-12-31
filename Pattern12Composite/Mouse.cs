using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern12Composite
{
    internal class Mouse : Item
    {
        private float _price = 18.00f;
        public float GetPrice()
        {
            return _price;
        }
    }
}
