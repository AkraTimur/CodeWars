using NUnit.Framework;
using Min_Factor_Distance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Factor_Distance.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(1, Kata.MinDistance(8));
            Assert.AreEqual(4, Kata.MinDistance(25));
            Assert.AreEqual(2, Kata.MinDistance(13013));
            Assert.AreEqual(200, Kata.MinDistance(557009));
            Assert.AreEqual(198, Kata.MinDistance(218683));
        }
    }
}