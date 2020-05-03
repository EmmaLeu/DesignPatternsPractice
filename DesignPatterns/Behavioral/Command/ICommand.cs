namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Common interface for performing a request
    /// The key idea in this pattern is to encapsulate a request in a separate object that:
    /// (1) can be used and passed around just like other objects and 
    /// (2) can be queued or logged to be called at a later point.
    /// </summary>
    /// <remarks>Commands are an object-oriented replacement for callbacks</remarks>
    public interface ICommand
    {
        void Execute();
    }
}
