using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern11Interpreter
{
    internal class SubtractionExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public SubtractionExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Context context)
        {
            return _left.Interpret(context) - _right.Interpret(context);
        }
    }
}
