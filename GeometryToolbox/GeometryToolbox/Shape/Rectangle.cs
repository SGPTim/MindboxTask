using System;
using GeometryToolbox.Shape.Query;

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

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}