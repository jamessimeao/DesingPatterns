using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Bad
{
    internal class WebServer
    {
        public void Handle(HttpRequest request)
        {
            Validator validator = new Validator();
            validator.Validate(request);

            Authenticator authenticator = new Authenticator();
            authenticator.Authenticate(request);

            Logger logger = new Logger();
            logger.Log(request);
        }
    }
}
