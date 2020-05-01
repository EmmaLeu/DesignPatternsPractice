using DesignPatterns.Structural.Flyweight;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class FlyweightTests
    {
        [Test]
        public void ClientOperation_Creates_OnlyOneFlyweightObject()
        {
            var client = new Client();

            var result = client.Operation();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void FlyweightOperation_Returns_CorrectMessage()
        {
            var flyweight = FlyweightFactory.Instance.GetFlyweight("A");

            var result = flyweight.Operation(100);

            Assert.AreEqual(string.Format(Resources.SharedFlyweightOperationMessage, 100, "A"), result);

            result = flyweight.Operation(200);

            Assert.AreEqual(string.Format(Resources.SharedFlyweightOperationMessage, 200, "A"), result);
        }
    }
}
