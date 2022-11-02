
using NUnit.Framework;
using System.Linq;

namespace TestProject2
{
    using No_oddities_here;
    [TestFixture]
    public class Tests
    {
        [Test]
        public void OneThroughFive()
        {
            Assert.That(NoOddities.NoOdds(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(new int[] { 2, 4 }));
        }
    }
}