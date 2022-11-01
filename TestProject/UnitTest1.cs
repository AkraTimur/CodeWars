using Abbreviate_a_Two_Word_Name;
namespace TestProject
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(Kata.AbbrevName("Sam Harris"), Is.EqualTo("S.H"));
            Assert.That(Kata.AbbrevName("Patrick Feenan"), Is.EqualTo("P.F"));
            Assert.That(Kata.AbbrevName("Evan Cole"), Is.EqualTo("E.C"));
            Assert.That(Kata.AbbrevName("P Favuzzi"), Is.EqualTo("P.F"));
            Assert.That(Kata.AbbrevName("David Mendieta"), Is.EqualTo("D.M"));
        }
    }
}