using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern12Composite
{
    internal class Keyboard : Item
    {
        private float _price = 40.0f;
        public float GetPrice()
        {
            return _price;
        }
    }
}
