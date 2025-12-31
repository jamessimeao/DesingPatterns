using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern12Composite
{
    internal class Microphone : Item
    {
        private float _price = 29.99f;
        public float GetPrice()
        {
            return _price;
        }
    }
}
