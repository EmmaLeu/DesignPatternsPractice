namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// Common interface for <see cref="Proxy"/> and <see cref="RealSubject"/>
    /// </summary>
    public interface ISubject
    {
        string Operation();
    }
}
