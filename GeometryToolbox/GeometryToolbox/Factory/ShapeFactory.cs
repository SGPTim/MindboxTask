using GeometryToolbox.Shape;

namespace GeometryToolbox.Factory
{
    public class ShapeFactory
    {
        public Circle CreateCircle(Point center, double radius)
        {
            if (radius < 0)
                throw new InvalidShapeArgumentException("Radius must be greater than zero.");

            return new Circle(center, radius);
        }

        public Triangle CreateTriangle(Point a, Point b, Point c)
        {
            if (a == b || b == c || a == c)
                throw new InvalidShapeArgumentException("Points must be different.");

            return new Triangle(a, b, c);
        }

        public Rectangle CreateRectangle(Point a, Point b)
        {
            if (a == b)
                throw new InvalidShapeArgumentException("Points must be different.");

            return new Rectangle(a, b);
        }
    }
}