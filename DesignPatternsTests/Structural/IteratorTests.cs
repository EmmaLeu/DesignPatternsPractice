using DesignPatterns.Behavioral.Iterator.Sample1;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class IteratorTests
    {
        [Test]
        public void ClientGetNames_Returns_FrontToBackNames()
        {
            var client = new Client(3);

            var result = client.GetElementNames();

            Assert.AreEqual("element0element1element2", result);
        }
    }
}
