using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Colleague2 : Colleague
    {
        private string _state;

        public Colleague2(IMediator mediator) : base(mediator)
        {
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            if (_state != state)
            {
                _state = state;
                Console.WriteLine($"{nameof(Colleague2)} My state changed to: {_state} Calling my mediator ...");
                _mediator.Mediate(this);
            }
        }

        public void Action2(string state)
        {
            // For example, synchronizing and displaying state. 
            _state = state;
            Console.WriteLine($"{nameof(Colleague2)} My state synchronized to: {_state}");
        }
    }
}
