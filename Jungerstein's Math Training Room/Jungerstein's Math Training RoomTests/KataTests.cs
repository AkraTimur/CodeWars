using NUnit.Framework;

namespace Jungerstein_s_Math_Training_Room.Tests
{
    [TestFixture()]
    public class KataTests
    {
        private static void Act(int expected, int n) => Assert.AreEqual(expected, Kata.CountZeros(n), $"Input -> n = {n}");

        [Test]
        public void BasicTests()
        {
            Act(0, 8);
            Act(1, 14);
            Act(3, 30);
        }

        [Test]
        public void LargerNumberTests()
        {
            Act(0, 487);
            Act(62, 500);
        }
    }
}