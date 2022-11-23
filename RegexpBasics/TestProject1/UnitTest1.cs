namespace TestProject1
{
    using RegexpBasics;
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That("".Digit(), Is.EqualTo(false));
            Assert.That("7".Digit(), Is.EqualTo(true));
            Assert.That(" ".Digit(), Is.EqualTo(false));
            Assert.That("a".Digit(), Is.EqualTo(false));
            Assert.That("a5".Digit(), Is.EqualTo(false));
            Assert.That("14".Digit(), Is.EqualTo(false));
        }
    }
}