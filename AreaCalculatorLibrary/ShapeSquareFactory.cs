namespace SquareCalculatorLibrary
{
    public class ShapeSquareFactory
    {
        public TriangleSquare Triangle(Point a, Point b, Point c)
        {
            return new TriangleSquare(a, b, c);
        }

        public virtual AbsShapeSquare FindSquare(params Point[] points)
        {
            AbsShapeSquare shapeSquare;

            if (points == null || points.Length <= 1)
                shapeSquare = new ZeroShapeSquare();
            else
            {
                switch (points.Length)
                {
                    case 2:
                        shapeSquare = Circle(points[0], points[1]);
                        break;
                    case 3:
                        shapeSquare = Triangle(points[0], points[1], points[2]);
                        break;
                    default:
                        shapeSquare = AnotherShape(points);
                        break;
                }
            }

            return shapeSquare;
        }

        protected virtual AbsShapeSquare AnotherShape(params Point[] points)
        {
            return Triangle(points[0], points[1], points[2]);
        }

        protected virtual AbsShapeSquare Circle(Point a, Point b)
        {
            return Circle(AbsShapeSquare.LineLength(a, b));
        }

        public AbsShapeSquare Circle(double radius)
        {
            return new CircleSquare(radius);
        }

        protected class ZeroShapeSquare : AbsShapeSquare
        {
            public override double Square()
            {
                return 0;
            }
        }
    }
}
