using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Memento
{
    /// <summary>
    /// Client responsible for requesting and holding mementos, but it is not permitted to access them
    /// </summary>
    public class Caretaker
    {
        public void Test()
        {
            var originator = new Originator();
            var mementos = new List<Originator.Memento>();

            originator.State = "A";
            var memento = originator.CreateMememto();
            Console.WriteLine($"Saving current state {originator.State}");
            mementos.Add(memento);
            
            originator.State = "B";
            memento = originator.CreateMememto();
            Console.WriteLine($"Saving current state {originator.State}");
            mementos.Add(memento);

            memento = mementos.First();
            originator.Restore(memento);
            Console.WriteLine($"Restoring to state {originator.State}");
        }
    }
}
