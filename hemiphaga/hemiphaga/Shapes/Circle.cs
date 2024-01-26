namespace hemiphaga
{
    public class Circle(double radius) : IShape
    {
        private readonly double _radius = radius;

        public double CalculateArea() => Math.PI * _radius * _radius;
    }
}
