using Regular_Ball_Super_Ball;

namespace FactorialTests
{
    [TestFixture]
    public class FactorialTest
    {
        [Test]
        public void ConstructorWithArgumentShouldSetBallTypeAsExpected()
        {
            Assert.That(new Ball("super").ballType, Is.EqualTo("super"));
        }

        [Test]
        public void DefaultConstructorShouldSetBallTypeToRegular()
        {
            Assert.That(new Ball("regular").ballType, Is.EqualTo("regular"));
        }

    }
}