using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern9ChainOfResponsability.Good
{
    internal abstract class Handler
    {
        private Handler _nextHandler;

        public abstract bool DoHandle(HttpRequest request);

        public Handler SetNext(Handler nextHandler)
        {
            _nextHandler = nextHandler;
            return nextHandler;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }
            
            if(_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }
    }
}
