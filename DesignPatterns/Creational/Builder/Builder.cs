namespace DesignPatterns.Creational.Builder
{
    public class Builder : IBuilder
    {
        private readonly ComplexObject _complexObject = new ComplexObject();

        public void BuildPartA()
        {
            _complexObject.Add(new ProductA());
        }

        public void BuildPartB()
        {
            _complexObject.Add(new ProductB());
        }

        public ComplexObject GetResult()
        {
            return _complexObject;
        }
    }
}
