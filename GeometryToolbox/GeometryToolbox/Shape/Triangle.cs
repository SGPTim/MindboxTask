using System;

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

        public bool IsRightTriangle()
        {
            var ablen = Algorithm.GetLength(B - A);
            var aclen = Algorithm.GetLength(C - A);
            var cblen = Algorithm.GetLength(B - C);

            ablen *= ablen;
            aclen *= aclen;
            cblen *= cblen;

            return (Math.Abs(ablen - (aclen + cblen)) < Algorithm.DoublePrecision)
                   || (Math.Abs(aclen - (ablen + cblen)) < Algorithm.DoublePrecision)
                   || (Math.Abs(cblen - (aclen + ablen)) < Algorithm.DoublePrecision);
        }

        public override double GetArea()
        {
            //т.к. модель построенна в 2д пространстве то просто вычислим площадь через векторное произведение
            // а не через 3 стороны.
            return Math.Abs((B.X - A.X) * (C.Y - A.Y) - (C.X - A.X) * (B.Y - A.Y)) / 2;
        }
    }
}