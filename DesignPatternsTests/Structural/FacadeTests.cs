using DesignPatterns.Structural.Facade;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class FacadeTests
    {
        [Test]
        public void Client_AccessesComponentOperations_ThroughFacade()
        {
            var client = new Client(new Facade(new Component1(), new Component2(), new Component3()));

            var result = client.Operation();

            Assert.AreEqual($"{nameof(Component1)}{nameof(Component2)}{nameof(Component3)}", result);
        }
    }
}
