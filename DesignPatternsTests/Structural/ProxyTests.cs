using NUnit.Framework;
using DesignPatterns.Structural.Proxy;

namespace DesignPatternsTests.Structural
{
    public class ProxyTests
    {
        [Test]
        public void ClientOperation_Returns_CorrectMessage()
        {
            var client = new Client();

            var result = client.Operation();

            Assert.AreEqual($"{nameof(Proxy)}{nameof(RealSubject)}", result);
        }
    }
}
