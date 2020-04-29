namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Defines an object that gets decorated
    /// </summary>
    public class Component1 : IComponent
    {
        public string Operation()
        {
            return nameof(Component1);
        }
    }
}
