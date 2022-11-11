namespace Solution
{
    using Define_a_card_suit;
    public class SolutionTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.DefineSuit("3♣"), Is.EqualTo("clubs"), "Should return clubs with \"3♣\"");
            Assert.That(Kata.DefineSuit("Q♠"), Is.EqualTo("spades"), "Should return spades with \"Q♠\"");
            Assert.That(Kata.DefineSuit("9♦"), Is.EqualTo("diamonds"), "Should return diamonds with \"9♦\"");
            Assert.That(Kata.DefineSuit("J♥"), Is.EqualTo("hearts"), "Should return hearts with \"J♥\"");
        }
    }
}