using Build_Tower;
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", Kata.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", Kata.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Kata.TowerBuilder(3)));
        }
    }
}