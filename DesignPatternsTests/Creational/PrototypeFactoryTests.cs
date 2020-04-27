using DesignPatterns.Creational.PrototypeFactory;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class PrototypeFactoryTests
    {
        [Test]
        public void Client_GetProductNames_WorksAsExpected()
        {
            var client = new PrototypeFactoryClient(new PrototypeFactory(new ProductA(nameof(ProductA)), new ProductB(nameof(ProductB))));

            var result = client.GetProductNames();

            Assert.AreEqual($"{nameof(ProductA)}{nameof(ProductB)}", result);
        }
    }
}
