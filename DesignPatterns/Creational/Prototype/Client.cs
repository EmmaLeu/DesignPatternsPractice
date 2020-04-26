namespace DesignPatterns.Prototype
{
    public class Client
    {
        private IProduct _product;

        private readonly IPrototype _prototype;

        public Client(IPrototype prototype)
        {
            _prototype = prototype;
        }

        public IProduct Operation()
        {
            _product = _prototype.Clone();

            return _product;
        }
    }
}
