namespace TestProject1
{
    using Exclamation_marks_series;
    [TestFixture]
    public class Test
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.Remove("Hi!"), Is.EqualTo("Hi!"));
            Assert.That(Kata.Remove("Hi!!!"), Is.EqualTo("Hi!"));
            Assert.That(Kata.Remove("!Hi"), Is.EqualTo("Hi!"));
            Assert.That(Kata.Remove("!Hi!"), Is.EqualTo("Hi!"));
            Assert.That(Kata.Remove("Hi! Hi!"), Is.EqualTo("Hi Hi!"));
            Assert.That(Kata.Remove("Hi"), Is.EqualTo("Hi!"));
        }
    }
}