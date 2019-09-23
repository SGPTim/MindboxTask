using System;
using GeometryToolbox.Shape;

namespace GeometryToolbox
{
    public static class Algorithm
    {
        /// <summary>
        /// Euclidean distance.
        /// </summary>
        /// <param name="point">Vector for calculating.</param>
        /// <returns>Distance.</returns>
        public static double GetLength(Point point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns>Scalar multiplication.</returns>
        public static double ScalarMultiplication(Point a, Point b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
    }
}