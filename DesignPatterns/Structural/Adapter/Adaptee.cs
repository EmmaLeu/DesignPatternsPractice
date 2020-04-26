namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Class that has an incompatible interface with <see cref="ITarget"/> and needs to be reused by <see cref="Client"/>
    /// </summary>
    public class Adaptee
    {
        public string SpecificOperation()
        {
            return nameof(Adaptee);
        }
    }
}
