using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Bad
{
    internal class Logger
    {
        public void Log(HttpRequest request)
        {
            Console.WriteLine("Log");
        }
    }
}
