namespace TestProject1
{
    using MexicanWave;
    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void BasicTest1()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.That(kata.wave("hello"), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest2()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.That(kata.wave("codewars"), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { };
            Assert.That(kata.wave(""), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.That(kata.wave("two words"), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.That(kata.wave(" gap "), Is.EqualTo(result), "it should return '" + result + "'");
        }

    }
}