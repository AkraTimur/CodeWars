namespace TestProject1
{
    using HelloNameOrWorld;
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.That(Kata.Hello("jEFF"), Is.EqualTo("Hello, Jeff!"));
            Assert.That(Kata.Hello("tonY"), Is.EqualTo("Hello, Tony!"));
            Assert.That(Kata.Hello("Alicia"), Is.EqualTo("Hello, Alicia!"));
            Assert.That(Kata.Hello("vasya"), Is.EqualTo("Hello, Vasya!"));
            Assert.That(Kata.Hello("JOHN"), Is.EqualTo("Hello, John!"));
            Assert.That(Kata.Hello(""), Is.EqualTo("Hello, World!"));
            //Assert.That(Kata.Hello(), Is.EqualTo("Hello, World!"));
        }
    }
}