using System;
using GeometryToolbox.Shape.Query;

namespace GeometryToolbox.Shape
{
    public class Circle : Shape
    {
        public Point Center { get; }
        public double Radius { get; }

        internal Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}