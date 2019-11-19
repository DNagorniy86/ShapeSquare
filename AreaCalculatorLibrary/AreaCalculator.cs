using System;

namespace AreaCalculatorLibrary
{
    public class SquareCalculator
    {
        public double TriangleSquare(uint sideA, uint sideB, uint sideC)
        {
            var p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public bool IsRightTriangle(uint a, uint b, uint c)
        {
            var hypotenuse = Math.Max(a, Math.Max(b, c));
            var sumSideSquare = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(b, 2);

            return Math.Abs(sumSideSquare - 2 * Math.Pow(hypotenuse, 2)) <= 0;
        }

        public double CircleSquare(uint radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
