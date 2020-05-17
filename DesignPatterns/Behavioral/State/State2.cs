using System;

namespace DesignPatterns.Behavioral.State
{
    public class State2 : IState
    {
        private static readonly Lazy<State2> _instance = new Lazy<State2>(() => new State2());

        private State2()
        {
        }

        public static State2 Instance => _instance.Value;

        public string Operation(Context context)
        {
            var result = string.Format(Resources.StateOperationFormat, nameof(State2), nameof(State1));
            //setting transition
            context.SetState(State1.Instance);
            return result;
        }
    }
}
