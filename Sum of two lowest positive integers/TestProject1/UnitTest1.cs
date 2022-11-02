namespace TestProject1
{
    using Sum_of_two_lowest_positive_integers;
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.That(Kata.sumTwoSmallestNumbers(numbers), Is.EqualTo(13));
        }

        [Test]
        public void Test2()
        {
            int[] numbers = { 19, 5, 42, 2, 77 };
            Assert.That(Kata.sumTwoSmallestNumbers(numbers), Is.EqualTo(7));
        }

        [Test]
        public void Test3()
        {
            int[] numbers = { 10, 343445353, 3453445, 2147483647 };
            Assert.That(Kata.sumTwoSmallestNumbers(numbers), Is.EqualTo(3453455));
        }
    }
}