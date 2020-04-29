using DesignPatterns.Structural.Decorator;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class DecoratorTests
    {
        [Test]
        public void Client_GetResultOperation_WhenUsingComponent1()
        {
            var client = new Client(new Component1());

            var result = client.GetResultOperation();

            Assert.AreEqual(nameof(Component1), result);
        }

        [Test]
        public void Client_GetResultOperation_WhenUsingDecorator1ComposedWithDecorator2()
        {
            var client = new Client(new Decorator1(new Decorator2(new Component1())));

            var result = client.GetResultOperation();

            Assert.AreEqual($"12{nameof(Component1)}21", result);
        }


        [Test]
        public void Client_GetResultOperation_WhenUsingDecorator2ComposedWithDecorator1()
        {
            var client = new Client(new Decorator2(new Decorator1(new Component1())));

            var result = client.GetResultOperation();

            Assert.AreEqual($"21{nameof(Component1)}12", result);
        }
    }
}
