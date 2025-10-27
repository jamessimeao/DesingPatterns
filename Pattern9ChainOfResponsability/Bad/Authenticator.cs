using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Bad
{
    internal class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            return request.GetUsername() == "danny" && request.GetPassword() == "123";
        }
    }
}
