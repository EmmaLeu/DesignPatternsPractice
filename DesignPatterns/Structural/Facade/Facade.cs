namespace DesignPatterns.Structural.Facade
{
    public class Facade : IFacade
    {
        private readonly Component1 _component1;
        private readonly Component2 _component2;
        private readonly Component3 _component3;

        public Facade(Component1 component1, Component2 component2, Component3 component3)
        {
            _component1 = component1;
            _component2 = component2;
            _component3 = component3;
        }

        public string Operation()
        {
            return _component1.Operation() + _component2.Operation() + _component3.Operation();
        }
    }
}
