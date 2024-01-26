namespace hemiphaga
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(string type, params double[] values)
        {
            return type switch
            {
                nameof(Circle) => CreateCircle(values[0]),
                nameof(Triangle) => CreateTriangle(values),
                _ => throw new InvalidOperationException("No shape found."),
            };
        }

        private static Circle CreateCircle(double radius) => new Circle(radius);
        private static Triangle CreateTriangle(params double[] dimensions) => new Triangle(dimensions[0], dimensions[1], dimensions[2]);
    }
}
