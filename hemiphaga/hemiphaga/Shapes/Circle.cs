namespace hemiphaga
{
    public class Circle(double radius) : IShape
    {
        private readonly double _radius = radius;

        public double Area => Math.PI * _radius * _radius;
    }
}
