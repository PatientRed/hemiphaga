﻿using static hemiphaga.Hemiphaga;

namespace hemiphaga
{
    public class Triangle : ICreatableShape<Triangle>
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

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
                        return Math.Abs(sq1 - sq2 - sq3) < Precision; //sq1 = sq2+sq3
                }
                else if (_side2 > _side3)
                    return Math.Abs(sq2 - sq1 - sq3) < Precision; //sq2 = sq1+sq3

                return Math.Abs(sq3 - sq1 - sq2) < Precision; //sq3 = sq1+sq2
            }
        }

        public double Area
        {
            get
            {
                //See Heron's formula
                var sp = (_side1 + _side2 + _side3) / 2;

                return Math.Sqrt(sp * (sp - _side1) * (sp - _side2) * (sp - _side3));
            }
        }

        private static bool VerifyTriangleCorrectness(double s1, double s2, double s3)
        {
            if (s1 < Precision || s2 < Precision || s3 < Precision) //any side <= 0
                return false;

            var sum = s1 + s2 + s3;
            double max = Math.Max(Math.Max(s1, s2), s3); ;

            return Math.Abs(max + max - sum) < Precision; //max < sum - max
        }

        public static Triangle Create(params double[] input) => new Triangle(input[0], input[1], input[2]);

        public Triangle(double side1, double side2, double side3)
        {
            if (!VerifyTriangleCorrectness(side1, side2, side3))
                throw new ArgumentException("Triangle is incorrect.");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
    }
}
