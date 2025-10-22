using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern7Observer.Good
{
    internal class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
