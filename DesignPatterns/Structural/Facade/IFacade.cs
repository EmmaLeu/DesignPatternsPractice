namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Acts as an interface for a more complex sub-system. Delegates operations to other objects
    /// </summary>
    public interface IFacade
    {
        string Operation();
    }
}
