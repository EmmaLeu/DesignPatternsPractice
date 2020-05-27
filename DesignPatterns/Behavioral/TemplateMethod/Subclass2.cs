namespace DesignPatterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Overrides only one primitive operation and reuses base primitive for the other one
    /// </summary>
    public class Subclass2 : AbstractClass
    {
        protected override string Primitive1()
        {
            return $"Primitive1: {nameof(Subclass2)}";
        }
    }
}
