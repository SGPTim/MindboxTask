using GeometryToolbox.Shape.Query;

namespace GeometryToolbox.Shape
{
    public abstract class Shape
    {
        public abstract void Accept(IVisitor visitor);
    }
}