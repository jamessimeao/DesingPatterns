using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern11Interpreter
{
    internal interface IExpression
    {
        int Interpret(Context context);
    }
}
