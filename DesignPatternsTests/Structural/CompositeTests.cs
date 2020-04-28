using DesignPatterns.Structural.Composite;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class CompositeTests
    {
        [Test]
        public void Component_Operation_DisplaysAllComponentNames()
        {
            var client = new Client();

            var component = client.BuildTree();

            Assert.AreEqual("composite1 leaf1 composite2 leaf3 leaf4 leaf5 leaf2", component.Operation());
        }
    }
}
