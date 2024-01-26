namespace hemiphaga
{
    public class Triangle(double side1, double side2, double side3) : IShape
    {
        private readonly double _side1 = side1;
        private readonly double _side2 = side2;
        private readonly double _side3 = side3;

        private const double _precision = .001;

        public bool IsRight
        {
            get
            {
                var sq1 = _side1 * _side1;
                var sq2 = _side2 * _side2;
                var sq3 = _side3 * _side3;

                if (_side1 > _side2)
                {
                    if (_side1 > _side3)
                        return Math.Abs(sq1 - sq2 - sq3) < _precision;
                }
                else if (_side2 > _side3)
                    return Math.Abs(sq2 - sq1 - sq3) < _precision;

                return Math.Abs(sq3 - sq1 - sq2) < _precision;
            }
        }

        public double CalculateArea()
        {
            //See Heron's formula
            var sp = (_side1 + _side2 + _side3) / 2;

            return Math.Sqrt(sp * (sp - _side1) * (sp - _side2) * (sp - _side3));
        }
    }
}
