using NUnit.Framework;

namespace TDDStarter.Tests
{
    [TestFixture]
    public class FooTests
    {
        [Test]
        public void Foo_Does_Something()
        {
            var foo = new Foo();
            Assert.That(foo, Is.InstanceOf<Foo>());
        }
    }
}
