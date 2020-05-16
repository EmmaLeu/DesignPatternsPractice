namespace DesignPatterns.Behavioral.Observer.Sample2
{
    /// <summary>
    /// Interface for synchronizing observer's state with subject's state
    /// </summary>
    public interface IObserver
    {
        void Update(Subject subject);
    }
}
