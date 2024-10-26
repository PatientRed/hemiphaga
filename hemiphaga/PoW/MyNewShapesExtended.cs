using hemiphaga;

//dll client extends basic functionality example
namespace PoW.MyShapes
{
    internal class Square(double side) : IShape
    {
        private readonly double _side = side;

        public double Area => _side * _side;
    }

    internal static class MyShapeFactory
    {
        public static IShape CreateShape(string name, params double[] values)
        {
            switch (name)
            {
                case nameof(Square):
                    return CreateSquare(values[0]);
                default:
                    return ShapeFactory.CreateShape(name, values);
            }
        }

        private static Square CreateSquare(double side) => new Square(side);
    }
}
