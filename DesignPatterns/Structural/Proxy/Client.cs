namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// Needs access to a subject
    /// </summary>
    public class Client
    {
        public string Operation()
        {
            var proxy = new Proxy(new RealSubject());

            return proxy.Operation();
        }
    }
}
