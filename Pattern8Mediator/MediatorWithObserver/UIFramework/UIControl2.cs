using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern8Mediator.MediatorWithObserver.UIFramework
{
    internal class UIControl2
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }

        public void NotifyEventHandlers()
        {
            foreach (EventHandler eventHandler in _eventHandlers)
            {
                eventHandler();
            }
        }
    }
}
