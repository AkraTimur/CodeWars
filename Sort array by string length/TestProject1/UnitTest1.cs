using Sort_array_by_string_length;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, Kata.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
            Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, Kata.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
            Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, Kata.SortByLength(new string[] { "Longer", "Longest", "Short" }));
        }
    }
}