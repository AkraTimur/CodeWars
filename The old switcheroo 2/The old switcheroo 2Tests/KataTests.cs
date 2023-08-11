using NUnit.Framework;

namespace The_old_switcheroo_2.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [Test]
        [TestCase("abc", ExpectedResult = "123")]
        [TestCase("ABCD", ExpectedResult = "1234")]
        [TestCase("ZzzzZ", ExpectedResult = "2626262626")]
        [TestCase("abc-#@5", ExpectedResult = "123-#@5")]
        [TestCase("this is a long string!! Please [encode] @C0RrEctly", ExpectedResult = "208919 919 1 1215147 1920189147!! 161251195 [51431545] @30181853201225")]
        public static string FixedTest(string str)
        {
            return Kata.Encode(str);
        }
    }
}
