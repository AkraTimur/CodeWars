using Reverse_words;

namespace TestReverseWords
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Example()
        {
            Assert.That(Kata.ReverseWords("This is an example!"), Is.EqualTo("sihT si na !elpmaxe"));
        }
    }
}