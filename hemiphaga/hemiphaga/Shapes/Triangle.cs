namespace hemiphaga
{
    public class Triangle(double side1, double side2, double side3) : IShape
    {
        private readonly double _side1 = side1;
        private readonly double _side2 = side2;
        private readonly double _side3 = side3;

        public double CalculateArea()
        {
            //See Heron's formula
            var sp = (_side1 + _side2 + _side3) / 2;

            return Math.Sqrt(sp * (sp - _side1) * (sp - _side2) * (sp - _side3));
        }
    }
}
