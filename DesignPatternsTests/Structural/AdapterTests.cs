using DesignPatterns.Structural.Adapter;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class AdapterTests
    {
        [Test]
        public void Client_UsingObjectAdapter_WorksAsExpected()
        {
            var client = new Client(new ObjectAdapter(new Adaptee()));

            var result = client.CallOperation();

            Assert.AreEqual(nameof(Adaptee), result);
        }

        [Test]
        public void Client_UsingClassAdapter_WorksAsExpected()
        {
            var client = new Client(new ClassAdapter());

            var result = client.CallOperation();

            Assert.AreEqual(nameof(Adaptee), result);
        }
    }
}
