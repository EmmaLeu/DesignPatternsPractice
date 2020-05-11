using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        private readonly Colleague1 _colleague1;
        private readonly Colleague2 _colleague2;

        public Client(Colleague1 colleague1, Colleague2 colleague2)
        {
            _colleague1 = colleague1;
            _colleague2 = colleague2;
        }

        public void Example()
        {
            Console.WriteLine($"(1) Changing state of {nameof(Colleague1)} ..."); 

            _colleague1.SetState("Hello World1!");

            Console.WriteLine($"\n(2) Changing state of {nameof(Colleague1)} ...");

            _colleague2.SetState("Hello World2!");
        }
    }
}
