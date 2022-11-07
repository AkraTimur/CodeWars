using Lario_and_Muigi_Pipe_Problem;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FixThosePipes_t1()
        {
            Assert.That(Fixer.PipeFix(new List<int> { 1, 2, 3, 5, 6, 8, 9 }), Is.EqualTo(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }

        [Test]
        public void FixThosePipes_t2()
        {
            Assert.That(Fixer.PipeFix(new List<int> { 1, 2, 3, 12 }), Is.EqualTo(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }));
        }

        [Test]
        public void FixThosePipes_t3()
        {
            Assert.That(Fixer.PipeFix(new List<int> { 6, 9 }), Is.EqualTo(new List<int> { 6, 7, 8, 9 }));
        }
    }
}