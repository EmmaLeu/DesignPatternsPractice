using DesignPatterns.Builder;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class BuilderTest
    {
        private Director _director;

        [SetUp]
        public void Setup()
        {
            _director = new Director(new Builder());
            _director.Construct();
        }

        [TearDown]
        public void TearDown()
        {
            _director = null;
        }

        [Test]
        public void Director_Construct_ComplexObjectIsNotNull()
        {
            Assert.IsNotNull(_director.ComplexObject);
        }

        [Test]
        public void Director_Construct_ComplexObjectHasExpectedChildren()
        {
            Assert.AreEqual($"{nameof(ProductA)},{nameof(ProductB)}", _director.ComplexObject.GetParts());
        }
    }
}
