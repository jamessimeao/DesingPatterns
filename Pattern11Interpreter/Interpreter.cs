using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern11Interpreter
{
    internal class Interpreter
    {
        private Context _context;

        public Interpreter(Context context)
        {
            _context = context;
        }

        public int Interpret(string expression)
        {
            IExpression expressionTree = BuildExpressionTree(expression);
            return expressionTree.Interpret(_context);
        }

        private IExpression BuildExpressionTree(string input)
        {
            // Hardcoded expression.
            // It is not the point here to implement the parsing algorithm.
            input = "1 + 2 * 3";
            IExpression expressionTree = 
                new AdditionExpression(
                    new NumberExpression(1),
                    new MultiplicationExpression(
                        new NumberExpression(2),
                        new NumberExpression(3)
                    )
                );
            return expressionTree;
        }
    }
}
