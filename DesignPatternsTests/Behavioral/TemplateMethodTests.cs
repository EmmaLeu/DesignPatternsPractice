using DesignPatterns.Behavioral.TemplateMethod;
using NUnit.Framework;

namespace DesignPatternsTests.Behavioral
{
    public class TemplateMethodTests
    {
        [Test]
        public void Subclass1OverridesBothAbstractPrimitives()
        {
            var subclass1 = new Subclass1();
            var expectedResult = $"Invariant code calling flexible primitives: Primitive1: {nameof(Subclass1)} Primitive2: {nameof(Subclass2)}";
            var result = subclass1.TemplateMethod();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Subclass2OverridesOnlyPrimitive1()
        {
            var subclass2 = new Subclass2();
            var expectedResult = $"Invariant code calling flexible primitives: Primitive1: {nameof(Subclass2)} Primitive2: {nameof(AbstractClass)}";
            var result = subclass2.TemplateMethod();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
