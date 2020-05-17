namespace DesignPatterns.Behavioral.State
{
    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            _state = state;
        }

        public string Operation()
        {
            return string.Format(Resources.ContextOperationFormat, nameof(Context), _state.Operation(this));
        }

        internal void SetState(IState state)
        {
            _state = state;
        }
    }
}
