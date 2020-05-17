using System;

namespace DesignPatterns.Behavioral.State
{
    public class State1 : IState
    {
        private static readonly Lazy<State1> _instance = new Lazy<State1>(() => new State1());

        private State1()
        {
        }

        public static State1 Instance => _instance.Value;

        public string Operation(Context context)
        {
            var result = string.Format(Resources.StateOperationFormat, nameof(State1), nameof(State2));
            //setting transition
            context.SetState(State2.Instance);
            return result;
        }
    }
}
