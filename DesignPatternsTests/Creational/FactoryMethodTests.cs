using DesignPatterns.Creational.FactoryMethod;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class FactoryMethodTests
    {
        [Test]
        public void CreatorA_Produces_ProductA()
        {
            Creator creator = new CreatorA();

            var result = creator.Operation();

            Assert.AreEqual(nameof(ProductA), result);
        }

        [Test]
        public void CreatorB_Produces_ProductB()
        {
            Creator creator = new CreatorB();

            var result = creator.Operation();

            Assert.AreEqual(nameof(ProductB), result);
        }
    }
}
