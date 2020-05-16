using System;

namespace DesignPatterns.Behavioral.Observer.Sample3
{
    public class Observer
    {
        public void Update(object sender, EventArgs args)
        {
            Console.WriteLine("Something happened to " + sender);
        }
    }
}
