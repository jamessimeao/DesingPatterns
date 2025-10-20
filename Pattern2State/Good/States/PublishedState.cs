using Pattern2State.Good;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern2State.Good.States
{
    internal class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {

        }
    }
}
