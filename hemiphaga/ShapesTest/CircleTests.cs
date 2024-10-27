using hemiphaga;
using System.Reflection;

namespace ShapesTest
{
    [TestClass]
    public class CircleTests
    {
        private const double _piArea = 1;

        [TestMethod]
        public void CircleCreationThrow()
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
        public void CircleAreaGood()
        {
            var res = Helper.Construct(nameof(Circle), [_piArea * 2]);

            Assert.AreEqual(Math.PI * 4, res.Area, Hemiphaga.Precision);
        }
    }
}