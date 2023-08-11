using NUnit.Framework;

namespace The_Office_II___Boredom_Score.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("kill me now", Kata.Boredom(new Dictionary<string, string>() { { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" } }));
            Assert.AreEqual("i can handle this", Kata.Boredom(new Dictionary<string, string>() { { "Jim", "pissing about" }, { "Tim", "regulation" }, { "Andy", "IS" }, { "Laura", "pissing about" }, { "Alex", "canteen" }, { "John", "canteen" } }));
            Assert.AreEqual("party time!!", Kata.Boredom(new Dictionary<string, string>() { { "Andy", "pissing about" }, { "Tim", "accounts" }, { "Smith", "pissing about" }, { "Randy", "pissing about" }, { "Sandy", "IS" }, { "Laura", "pissing about" } }));
        }
    }
}
