using DesignPatterns.Behavioral.Observer.Sample1;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class ObserverTests
    {
        [Test]
        public void Sample1_ObserversAreNotified_OnSubjectUpdate()
        {
            var subject = new Subject1();
            var observer1 = new Observer1(subject);
            var observer2 = new Observer2(subject);

            subject.State = 2;

            Assert.AreEqual(2, observer1.State);
            Assert.AreEqual(2, observer2.State);
        }
    }
}
