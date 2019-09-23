using System;

namespace GeometryToolbox.Shape
{
    public class Rectangle : Shape
    {
        public Point A { get; }
        public Point B { get; }

        internal Rectangle(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public override double GetArea()
        {
            double width = Math.Abs(B.X - A.X);
            double height = Math.Abs(B.Y - A.Y);

            return width * height;
        }
    }
}