using System;
using GeometryToolbox.Shape.Query;

namespace GeometryToolbox.Shape
{
    public class Triangle : Shape
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }

        internal Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}