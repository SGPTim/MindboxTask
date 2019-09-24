using GeometryToolbox.Factory;
using GeometryToolbox.Shape;
using NUnit.Framework;

namespace Tests
{
    public class TriangleTests
    {
        private ShapeFactory _shapeFactory;

        [SetUp]
        public void Setup()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        public void IsRightTriangleTest()
        {
            var a = new Point(0, 0);
            var b = new Point(1, 0);
            var c = new Point(0, 1);
            var d = new Point(10, 10);
            var rightTriangle = _shapeFactory.CreateTriangle(a, b, c);
            var notRightTriangle = _shapeFactory.CreateTriangle(a, b, d);

            Assert.AreEqual(rightTriangle.IsRightTriangle(), true);
            Assert.AreEqual(notRightTriangle.IsRightTriangle(), false);
        }

        [Test]
        public void GetAreaTest()
        {
            var a = new Point(0, 0);
            var b = new Point(1, 0);
            var c = new Point(0, 1);
            var shape = _shapeFactory.CreateTriangle(a, b, c);

            var area = shape.GetArea();
            Assert.AreEqual(area, .5);
        }
    }
}