using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Colleague1 : Colleague
    {
        private string _state;

        public Colleague1(IMediator mediator) : base(mediator)
        {
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            if(_state != state)
            {
                _state = state;
                Console.WriteLine($"{nameof(Colleague1)} My state changed to: {_state} Calling my mediator ..."); 
                _mediator.Mediate(this);
            }
        }
        
        public void Action1(string state)
        {
            // For example, synchronizing and displaying state. 
            _state = state;
            Console.WriteLine($"{nameof(Colleague1)} My state synchronized to: {_state}");
        } 
    }
}
