using hemiphaga;

//dll client extends basic functionality example
namespace PoW.MyShapes
{
    internal class Square(double side) : ICreatableShape<Square>
    {
        private readonly double _side = side;

        public double Area => _side * _side;

        public static Square Create(params double[] input) => new Square(input[0]);
    }

    internal static class MyShapeFactory
    {
        public static IShape CreateShape(string name, params double[] values)
        {
            switch (name)
            {
                case nameof(Square):
                    return Square.Create(values[0]);
                default:
                    return ShapeFactory.CreateShape(name, values);
            }
        }
    }
}
