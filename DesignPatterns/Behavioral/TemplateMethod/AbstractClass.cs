namespace DesignPatterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Class defining inflexible code for an operation and variant code that can be implemented by subclasses
    /// </summary>
    public abstract class AbstractClass
    {
        protected abstract string Primitive1();

        protected virtual string Primitive2()
        {
            return $" Primitive2: {nameof(AbstractClass)}";
        }

        public string TemplateMethod()
        {
            var result = "Invariant code calling flexible primitives: ";
            result += Primitive1();
            result += Primitive2();
            return result;
        }
    }
}
