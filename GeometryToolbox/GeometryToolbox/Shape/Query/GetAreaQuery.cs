using System;

namespace GeometryToolbox.Shape.Query
{
    /// <summary>
    /// Query for getting the area of shape.
    /// </summary>
    public class GetAreaQuery : IVisitor
    {
        /// <summary>
        /// Calculated area.
        /// </summary>
        public double Result { get; private set; }

        /// <summary>
        /// Calculate area from shape.
        /// </summary>
        /// <param name="circle">Circle.</param>
        public void Visit(Circle circle)
        {
            Result = Math.PI * circle.Radius * circle.Radius;
        }

        /// <summary>
        /// Calculate area from shape.
        /// </summary>
        /// <param name="rectangle">Rectangle.</param>
        public void Visit(Rectangle rectangle)
        {
            Point a = rectangle.A;
            Point b = rectangle.B;
            double width = Math.Abs(b.X - a.X);
            double height = Math.Abs(b.Y - a.Y);

            Result = width * height;            
        }

        /// <summary>
        /// Calculate area from shape.
        /// </summary>
        /// <param name="triangle">Triangle.</param>
        public void Visit(Triangle triangle)
        {
            Point a = triangle.A;
            Point b = triangle.B;
            Point c = triangle.C;
            
            //т.к. модель построенна в 2д пространстве то просто вычислим площадь через векторное произведение
            // а не через 3 стороны.
            Result = Math.Abs((b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.Y)) / 2;
        }
    }
}