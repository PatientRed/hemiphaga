﻿using static hemiphaga.Hemiphaga;

namespace hemiphaga
{
    public class Circle(double radius) : ICreatableShape<Circle>
    {
        private readonly double _radius = radius;

        public double Area => Math.PI * _radius * _radius;

        public static Circle Create(params double[] input) => new Circle(input[0]);

        private bool VerifyCircleCorrectness(double r)
        {
            if (r < Precision)
                return false;

            return true;
        }
    }
}
