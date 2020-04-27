using System;

namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Bridges abstraction and implementation
    /// Delegates <see cref="IAbstraction"/> implementation to <see cref="IImplementor"/>
    /// </summary>
    public class Abstraction : IAbstraction
    {
        private readonly IImplementor _implementor;

        public Abstraction(IImplementor implementor)
        {
            _implementor = implementor;
        }

        public string Operation()
        {
            return _implementor.OperationImpl();
        }
    }
}
