using System;
using System.Runtime.CompilerServices;

namespace GeometryToolbox.Shape
{
    public struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        public double X { get; }
        public double Y { get; }

        public override bool Equals(object obj) => obj is Point && Equals((Point) obj);

        public bool Equals(Point other) => this == other;

        public override int GetHashCode() => HashCode.Combine(X, Y);

        public static bool operator ==(Point left, Point right) => left.X == right.X && left.Y == right.Y;

        public static bool operator !=(Point left, Point right) => !(left == right);
    }
}