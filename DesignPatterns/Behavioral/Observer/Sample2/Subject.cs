using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer.Sample2
{
    /// <summary>
    /// Mantains a list of <see cref="IObserver"/> and notifies them when it's state changes
    /// Allows observers registration and unregistration
    /// </summary>
    public abstract class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
