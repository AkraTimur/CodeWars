namespace Solution
{
    using ShortestWord;
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(Kata.FindShort("bitcoin take over the world maybe who knows perhaps"), Is.EqualTo(3));
            Assert.That(Kata.FindShort("turns out random test cases are easier than writing out basic ones"), Is.EqualTo(3));
            Assert.That(Kata.FindShort("Let's travel abroad shall we"), Is.EqualTo(2));
        }
    }
}