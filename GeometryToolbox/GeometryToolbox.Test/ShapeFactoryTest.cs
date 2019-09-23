using System;
using GeometryToolbox;
using GeometryToolbox.Factory;
using GeometryToolbox.Shape;
using NUnit.Framework;

namespace Tests
{
    public class ShapeFactoryTest
    {
        private ShapeFactory _shapeFactory;

        [SetUp]
        public void Setup()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(Double.MaxValue, Double.MaxValue)]
        [TestCase(Double.MaxValue, Double.MinValue)]
        [TestCase(Double.MinValue, Double.MaxValue)]
        [TestCase(Double.MinValue, Double.MinValue)]
        public void CreateRectangle(double x, double y)
        {
            var a = new Point(x, y);
            var b = new Point(y, x);

            if (a == b)
            {
                Assert.Catch<InvalidShapeArgumentException>(() =>
                {
                    var shape = _shapeFactory.CreateRectangle(a, b);
                });
            }
            else
            {
                var shape = _shapeFactory.CreateRectangle(a, b);
                Assert.AreEqual(shape.A, a);
                Assert.AreEqual(shape.B, b);    
            }
        }

        [Test]
        [TestCase(Double.MaxValue, Double.MaxValue, Double.MaxValue)]
        [TestCase(Double.MaxValue, Double.MaxValue, Double.MinValue)]
        [TestCase(Double.MaxValue, Double.MinValue, Double.MaxValue)]
        [TestCase(Double.MaxValue, Double.MinValue, Double.MinValue)]
        [TestCase(Double.MinValue, Double.MaxValue, Double.MaxValue)]
        [TestCase(Double.MinValue, Double.MaxValue, Double.MinValue)]
        [TestCase(Double.MinValue, Double.MinValue, Double.MaxValue)]
        [TestCase(Double.MinValue, Double.MinValue, Double.MinValue)]
        public void CreateCircle(double x, double y, double radius)
        {
            var center = new Point(x, y);

            if (radius < 0)
            {
                Assert.Catch<InvalidShapeArgumentException>(() =>
                {
                    _shapeFactory.CreateCircle(center, radius);
                });
            }
            else
            {
                var shape = _shapeFactory.CreateCircle(center, radius);
                Assert.AreEqual(shape.Center, center);
                Assert.AreEqual(shape.Radius, radius);   
            }
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(double.MaxValue, double.MaxValue)]
        [TestCase(double.MaxValue, double.MinValue)]
        [TestCase(double.MinValue, double.MaxValue)]
        [TestCase(double.MinValue, double.MinValue)]
        public void CreateTriangle(double x, double y)
        {
            var a = new Point(x, y);
            var b = new Point(y, x);
            var c = new Point(x, x);

            if (a == b || b == c || c == a)
            {
                Assert.Catch<InvalidShapeArgumentException>(() =>
                {
                    _shapeFactory.CreateTriangle(a, b, b);
                });
            }
            else
            {
                var shape = _shapeFactory.CreateTriangle(a, b, c);
                Assert.AreEqual(shape.A, a);
                Assert.AreEqual(shape.B, b);
                Assert.AreEqual(shape.C, c);
            }
        
        }
    }
}