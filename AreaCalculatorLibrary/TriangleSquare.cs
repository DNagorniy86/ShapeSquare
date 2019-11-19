using System;
using AreaCalculatorLibrary;

namespace SquareCalculatorLibrary
{
    public sealed class TriangleSquare : AbsShapeSquare
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        internal TriangleSquare(Point a, Point b, Point c)
        {
            _sideA = LineLength(a, b);
            _sideB = LineLength(b, c);
            _sideC = LineLength(c, a);
        }

        public override double Square()
        {
            return CalculateSquare((_sideA + _sideB + _sideC) / 2, _sideA, _sideB, _sideC);
        }

        public bool IsRight()
        {
            var hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
            var sumSideSquare = Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2);

            return Math.Abs(sumSideSquare - 2 * Math.Pow(hypotenuse, 2)) <= 0;
        }

        private static double CalculateSquare(double perimeter, double sideA, double sideB, double sideC)
        {
            return Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        }
    }
}