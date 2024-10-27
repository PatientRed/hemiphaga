using System.Reflection;

namespace hemiphaga.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        private static readonly double[] _right = [3, 4, 5];
        private static readonly double[] _notRight = [3, 4, 6];
        private static readonly double[] _incorrect = [4, 4, 8];

        [TestMethod()]
        public void TriangleCreationThrowTest()
        {
            int i = 0;

            foreach (var per in Helper.PermutationsThree(_incorrect))
            {
                i++;

                try
                {
                    var temp = Helper.Construct(nameof(Triangle), per);
                }
                catch (Exception ex)
                {
                    Assert.IsInstanceOfType<TargetInvocationException>(ex);
                    Assert.IsInstanceOfType<ArgumentException>(ex.InnerException);
                }
            }

            Assert.AreEqual(6, i);
        }

        [TestMethod()]
        public void TriangleAreaTest()
        {
            Assert.AreEqual(Helper.Construct(nameof(Triangle), _right).Area, 6, Hemiphaga.Precision);
        }

        [TestMethod]
        public void TriangleRightnessGoodTest()
        {
            var t = Helper.Construct(nameof(Triangle), _right);

            Assert.IsInstanceOfType<Triangle>(t);
            Assert.IsTrue((t as Triangle).IsRight);
        }

        [TestMethod]
        public void TriangleRightnessBadTest()
        {
            var t = Helper.Construct(nameof(Triangle), _notRight);

            Assert.IsInstanceOfType<Triangle>(t);
            Assert.IsFalse((t as Triangle).IsRight);
        }
    }
}