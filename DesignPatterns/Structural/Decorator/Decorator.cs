namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Adds behavior to <see cref="IComponent"/> dynamically. Acts as a transparent enclosure of the object being decorated
    /// </summary>
    public abstract class Decorator : IComponent
    {
        private readonly IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual string Operation()
        {
            //forward to component
            return _component.Operation();
        }
    }
}
