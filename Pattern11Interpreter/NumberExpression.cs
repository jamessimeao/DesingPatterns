using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern11Interpreter
{
    internal class NumberExpression : IExpression
    {
        private int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public NumberExpression(string number)
        {
            _number = int.Parse(number);
        }

        public int Interpret(Context context)
        {
            return _number;
        }
    }
}
