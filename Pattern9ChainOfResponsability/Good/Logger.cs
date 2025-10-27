using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Good
{
    internal class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}
