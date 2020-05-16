using System;

namespace DesignPatterns.Behavioral.Observer.Sample3
{
    public class Observable
    {
        public event EventHandler SomethingHappened;

        public void Notify() => SomethingHappened?.Invoke(this, EventArgs.Empty);
    }
}
