using DesignPatterns.Structural.Bridge;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class BridgeTests
    {
        [Test]
        public void Abstraction_DelegatsTo_Implementation()
        {
            var abstraction = new Abstraction(new Implementor());

            var result = abstraction.Operation();

            Assert.AreEqual(nameof(Implementor), result);
        }
    }
}
