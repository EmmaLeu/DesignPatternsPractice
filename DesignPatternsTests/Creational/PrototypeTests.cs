using DesignPatterns.Creational.Prototype;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class PrototypeTests
    {
        [Test]
        public void ClientOperation_ClonesProduct_ThroughPrototype()
        {
            var prototype = new Product(nameof(Product));
            var client = new Client(prototype);

            var result = client.Operation();

            Assert.AreEqual(prototype.GetName(), result.GetName());
            Assert.AreNotEqual(prototype.GetHashCode(), result.GetHashCode());
        }
    }
}
