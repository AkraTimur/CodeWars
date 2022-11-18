namespace TestProject1
{
    using Find_the_position;
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(Kata.Position('a'), Is.EqualTo("Position of alphabet: 1"));
            Assert.That(Kata.Position('z'), Is.EqualTo("Position of alphabet: 26"));
            Assert.That(Kata.Position('e'), Is.EqualTo("Position of alphabet: 5"));
        }
    }
}