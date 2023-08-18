using NUnit.Framework;
using Array_element_parity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_element_parity.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.Solve(new List<int> { 1, -1, 2, -2, 3 }), Is.EqualTo(3));
            Assert.That(Kata.Solve(new List<int> { -3, 1, 2, 3, -1, -4, -2 }), Is.EqualTo(-4));
            Assert.That(Kata.Solve(new List<int> { 1, -1, 2, -2, 3, 3 }), Is.EqualTo(3));
            Assert.That(Kata.Solve(new List<int> { -110, 110, -38, -38, -62, 62, -38, -38, -38 }), Is.EqualTo(-38));
            Assert.That(Kata.Solve(new List<int> { -9, -105, -9, -9, -9, -9, 105 }), Is.EqualTo(-9));
        }
    }
}