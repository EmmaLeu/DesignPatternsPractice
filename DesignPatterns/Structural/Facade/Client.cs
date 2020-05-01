namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Accesses the existing subsystem through a facade <see cref="IFacade"/>
    /// </summary>
    public class Client
    {
        private readonly IFacade _facade;

        public Client(IFacade facade)
        {
            _facade = facade;
        }

        public string Operation()
        {
            return _facade.Operation();
        }
    }
}
