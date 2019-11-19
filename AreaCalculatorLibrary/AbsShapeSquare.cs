using System;
using AreaCalculatorLibrary;

namespace SquareCalculatorLibrary
{
    public abstract class AbsShapeSquare
    {
        public abstract double Square();

        protected internal static double LineLength(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }
}