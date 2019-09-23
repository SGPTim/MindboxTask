namespace GeometryToolbox.Shape.Query
{
    /// <summary>
    /// Query for checking is shape right triangle.
    /// </summary>
    public class IsRightTriangle : IVisitor
    {
        /// <summary>
        /// Is shape right triangle.
        /// </summary>
        public bool Result { get; private set; }

        /// <summary>
        /// Check is shape right triangle.
        /// </summary>
        /// <param name="circle"></param>
        public void Visit(Circle circle)
        {
            Result = false;
        }

        /// <summary>
        /// Check is shape right triangle.
        /// </summary>
        /// <param name="rectangle">Rectangle.</param>
        public void Visit(Rectangle rectangle)
        {
            Result = false;
        }

        /// <summary>
        /// Check is shape right triangle.
        /// </summary>
        /// <param name="triangle">Triangle.</param>
        public void Visit(Triangle triangle)
        {
            Point a = triangle.A;
            Point b = triangle.B;
            Point c = triangle.A;

            var ablen = Algorithm.GetLength(b - a);
            var aclen = Algorithm.GetLength(c - a);
            var cblen = Algorithm.GetLength(b - c);

            ablen *= ablen;
            aclen *= aclen;
            cblen *= cblen;

            Result = (ablen == aclen + cblen)
                     || (aclen == ablen + cblen)
                     || (cblen == aclen + ablen);
        }
    }
}