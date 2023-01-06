using Removing_Elements;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTest()
        {
            Assert.That(Kata.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }), Is.EqualTo(new object[] { "Hello", "Hello Again" }));
            Assert.That(Kata.RemoveEveryOther(new object[] { new object[] { 1, 2 } }), Is.EqualTo(new object[] { new object[] { 1, 2 } }));
            Assert.That(Kata.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), Is.EqualTo(new object[] { 1, 3, 5, 7, 9 }));
            Assert.AreEqual(new object[] { new object[] { "Goodbye" } }, Kata.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }));
            Assert.AreEqual(new object[] { }, Kata.RemoveEveryOther(new object[] { }));
        }
    }
}