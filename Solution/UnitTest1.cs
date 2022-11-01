namespace Solution
{
    using No_oddities_here;
    using System.Linq;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OneThroughFive()
        {
            Assert.AreEqual(new int[] { 2, 4 }, NoOddities.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
        }
    }
}
