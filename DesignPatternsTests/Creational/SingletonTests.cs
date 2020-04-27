using DesignPatterns.Creational.Singleton;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class SingletonTests
    {
        [Test]
        public void Singleton_Intance_ReturnsSameInstance()
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            Assert.AreEqual(instance1, instance2);
        }
    }
}
