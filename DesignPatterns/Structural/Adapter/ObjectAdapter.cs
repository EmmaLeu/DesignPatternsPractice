namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Implements the <see cref="ITarget"/> in terms of (delegating to) <see cref="Adaptee"/>
    /// </summary>
    public class ObjectAdapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public ObjectAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string Operation()
        {
            return _adaptee.SpecificOperation();
        }
    }
}
