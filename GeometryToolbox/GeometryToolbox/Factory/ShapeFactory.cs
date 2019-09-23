using GeometryToolbox.Shape;

namespace GeometryToolbox.Factory
{
    /// <summary>
    /// Factory for shapes.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Methrod create a circle.
        /// </summary>
        /// <param name="center">Center of circle.</param>
        /// <param name="radius">Redius.</param>
        /// <returns>Circle object.</returns>
        /// <exception cref="InvalidShapeArgumentException"></exception>
        public Circle CreateCircle(Point center, double radius)
        {
            if (radius < 0)
                throw new InvalidShapeArgumentException("Radius must be greater than zero.");

            return new Circle(center, radius);
        }

        /// <summary>
        /// Method create a trianle.
        /// </summary>
        /// <param name="a">First point.</param>
        /// <param name="b">Second point.</param>
        /// <param name="c">Third point.</param>
        /// <returns>Triangle object.</returns>
        /// <exception cref="InvalidShapeArgumentException"></exception>
        public Triangle CreateTriangle(Point a, Point b, Point c)
        {
            if (a == b || b == c || a == c)
                throw new InvalidShapeArgumentException("Points must be different.");

            return new Triangle(a, b, c);
        }

        /// <summary>
        /// Method create a rectangle.
        /// </summary>
        /// <param name="a">First diagonal point.</param>
        /// <param name="b">Second diagonal point.</param>
        /// <returns>Rectangle object.</returns>
        /// <exception cref="InvalidShapeArgumentException"></exception>
        public Rectangle CreateRectangle(Point a, Point b)
        {
            if (a == b)
                throw new InvalidShapeArgumentException("Points must be different.");

            return new Rectangle(a, b);
        }
    }
}