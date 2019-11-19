using System;
using AreaCalculatorLibrary;

namespace SquareCalculatorLibrary
{
    internal sealed class CircleSquare : AbsShapeSquare
    {
        private readonly double _radius;

        public CircleSquare(double radius)
        {
            _radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}