namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Requires an <see cref="ITarget"/>
    /// </summary>
    public class Client
    {
        private readonly ITarget _target;

        public Client(ITarget target)
        {
            _target = target;
        }
             
        public string CallOperation()
        {
            return _target.Operation();
        }
    }
}
