namespace DesignPatterns.Structural.Decorator
{
    public class Client
    {
        private readonly IComponent _component;

        public Client(IComponent component)
        {
            _component = component;
        }

        public string GetResultOperation()
        {
            return _component.Operation();
        }
    }
}
