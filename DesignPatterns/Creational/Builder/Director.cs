namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Director delegates the creation of <see cref="ComplexObject"/> to another class <see cref="IBuilder"/>
    /// </summary>
    public class Director
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();

            ComplexObject = _builder.GetResult();
        }

        public ComplexObject ComplexObject { get; private set; }
    }
}
