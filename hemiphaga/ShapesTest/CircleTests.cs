using System.Reflection;

namespace hemiphaga.Tests
{
    [TestClass]
    public class CircleTests
    {
        private const double _piArea = 1;

        [TestMethod]
        public void CircleCreationThrowTest()
        {
            var r = 0;

            try
            {
                Helper.Construct(nameof(Circle), [r]);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType<TargetInvocationException>(ex);
                Assert.IsInstanceOfType<ArgumentOutOfRangeException>(ex.InnerException);
            }
        }

        [TestMethod]
        public void CircleAreaGoodTest()
        {
            var res = Helper.Construct(nameof(Circle), [_piArea * 2]);

            Assert.AreEqual(Math.PI * 4, res.Area, Hemiphaga.Precision);
        }
    }
}