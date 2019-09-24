using GeometryToolbox.Factory;
using GeometryToolbox.Shape;
using NUnit.Framework;

namespace Tests
{
    public class TriangleTest
    {
        private ShapeFactory _shapeFactory;

        [SetUp]
        public void Setup()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        public void GetAreaTest()
        {
            var a = new Point(1, 0);
            var b = new Point(0, 1);
            var shape = _shapeFactory.CreateRectangle(a, b);

            var area = shape.GetArea();
            Assert.AreEqual(area, 1);
        }
    }
}