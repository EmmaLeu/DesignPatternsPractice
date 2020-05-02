namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// Implements additional functionality to control the access to <see cref="RealSubject"/>
    /// </summary>
    /// <remarks>
    /// Common examples of proxy:
    /// - Protection proxy: acts as placeholder for sensitive objects to check that clients have the rights to access them
    /// - Virtual proxy: acts as placeholder for expensive objects to defer their creation until it is needed
    /// - Remote proxy: acts as placeholder for remote objects to hide the complex network communication details from clients
    /// </remarks>
    public class Proxy : ISubject
    {
        private readonly RealSubject _subject;

        public Proxy(RealSubject subject)
        {
            _subject = subject;
        }

        public string Operation()
        {
            //does extra work and redirects to RealSubject operation
            return nameof(Proxy) + _subject.Operation();
        }
    }
}
