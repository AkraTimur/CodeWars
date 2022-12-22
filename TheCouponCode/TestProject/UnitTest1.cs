using TheCouponCode;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public static void ValidCoupon()
        {
            Assert.That(Kata.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"), Is.EqualTo(true));
        }

        [Test]
        public static void InvalidCoupon()
        {
            Assert.That(Kata.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"),Is.EqualTo(false));
        }
    }
}
