using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Good
{
    internal class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}
