using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Good
{
    internal class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            return !(request.GetUsername() == "danny" && request.GetPassword() == "123");
        }
    }
}
