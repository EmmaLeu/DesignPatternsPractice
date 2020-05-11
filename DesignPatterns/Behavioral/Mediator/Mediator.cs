using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Mediator : IMediator
    {
        private readonly Colleague1 _colleague1;
        private readonly Colleague2 _colleague2;

        public Mediator(Colleague1 colleague1, Colleague2 colleague2)
        {
            _colleague1 = colleague1;
            _colleague2 = colleague2;
        }

        public void Mediate(Colleague colleague)
        {
            Console.WriteLine("Meadiating colleagues....");
            if (colleague == _colleague1)
            {
                //Performing an action on colleague2
                var state = _colleague1.GetState();
                _colleague2.Action2(state);
            }
            else if (colleague == _colleague2)
            {
                //Performing an action on colleague1
                var state = _colleague2.GetState();
                _colleague1.Action1(state);
            }
        }
    }
}
