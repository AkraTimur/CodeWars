using NUnit.Framework;

namespace The_Most_Amicable_of_Numbers.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [Test]
        [TestCase(220, 284, ExpectedResult = true)]
        [TestCase(220, 280, ExpectedResult = false)]
        [TestCase(1184, 1210, ExpectedResult = true)]
        [TestCase(220221, 282224, ExpectedResult = false)]
        public static bool FixedTest(int num1, int num2)
        {
            return Kata.AmicableNumbers(num1, num2);
        }
    }
}