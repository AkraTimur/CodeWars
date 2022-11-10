namespace Solution
{
    using Find_the_unique_number;
    [TestFixture]
    public class SolutionTest
    {
        [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
        [TestCase(new[] { 8, 8, 8, 8, 7 }, ExpectedResult = 7)]
        public int BaseTest(IEnumerable<int> numbers)
        {
            return Kata.GetUnique(numbers);
        }
    }
}
