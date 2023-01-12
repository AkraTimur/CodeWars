using Largest_pair_sum_in_array;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.LargestPairSum(new int[] { -8, -8, -16, -18, -19 }), Is.EqualTo(-16));
            Assert.That(Kata.LargestPairSum(new int[] { -100, -29, -24, -19, 19 }), Is.EqualTo(0));
            Assert.That(Kata.LargestPairSum(new int[] { 1, 2, 3, 4, 6, -1, 2 }), Is.EqualTo(10));
            Assert.That(Kata.LargestPairSum(new int[] { 10, 14, 2, 23, 19 }), Is.EqualTo(42));
        }
    }
}