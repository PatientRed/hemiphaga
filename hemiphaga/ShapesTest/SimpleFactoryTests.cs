namespace hemiphaga.Tests
{
    internal class Rectangle : ICreatableShape<Rectangle>
    {
        public double Area => throw new NotImplementedException();

        public static Rectangle Create(params double[] input)
        {
            return new Rectangle();
        }
    }

    [TestClass]
    public class SimpleFactoryTests
    {
        [TestMethod]
        public void FactoryCustomFigureGoodTest()
        {
            Assert.IsInstanceOfType<Rectangle>(Helper.Construct(nameof(Rectangle), []));
        }
    }
}
