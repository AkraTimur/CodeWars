using DeodorantEvaporator;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(Evaporator.evaporator(10, 10, 10), Is.EqualTo(22));
        }
    }
}
