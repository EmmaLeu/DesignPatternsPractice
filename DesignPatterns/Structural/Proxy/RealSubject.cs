namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// Defines objects that get substitued (already existing object class)
    /// </summary>
    public class RealSubject : ISubject
    {
        public string Operation()
        {
            return nameof(RealSubject);
        }
    }
}
