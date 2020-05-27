namespace DesignPatterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Overrides both primitive operations
    /// </summary>
    public class Subclass1 : AbstractClass
    {
        protected override string Primitive1()
        {
            return $"Primitive1: {nameof(Subclass1)}";
        }

        protected override string Primitive2()
        {
            return $" Primitive2: {nameof(Subclass2)}";
        }
    }
}
