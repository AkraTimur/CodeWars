using Highest_Scoring_Word;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
                yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
                yield return new TestCaseData("take me to semynak").Returns("semynak");
                yield return new TestCaseData("aa b").Returns("aa");
                yield return new TestCaseData("b aa").Returns("b");
                yield return new TestCaseData("bb d").Returns("bb");
                yield return new TestCaseData("d bb").Returns("d");
                yield return new TestCaseData("aaa b").Returns("aaa");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string s) => Kata.High(s);
    }
}