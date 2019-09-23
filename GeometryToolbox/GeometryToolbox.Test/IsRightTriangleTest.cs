using System;
using GeometryToolbox.Factory;
using GeometryToolbox.Shape;
using GeometryToolbox.Shape.Query;
using NUnit.Framework;

namespace Tests
{
    public class IsRightTriangleTest
    {
        private ShapeFactory _shapeFactory;

        [SetUp]
        public void Setup()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        public void IsRightRectangleTest()
        {
            var a = new Point(1, 0);
            var b = new Point(0, 1);
            var shape = _shapeFactory.CreateRectangle(a, b);
            var visitor = new IsRightTriangle();

            visitor.Visit(shape);
            Assert.AreEqual(visitor.Result, false);
        }

        [Test]
        public void IsRightCircleTest()
        {
            var center = new Point(0, 1);
            var shape = _shapeFactory.CreateCircle(center, 2);
            var visitor = new IsRightTriangle();

            visitor.Visit(shape);
            Assert.AreEqual(visitor.Result, false);
        }

        private void IsRightTrianglePositiveTest()
        {
            var a = new Point(0, 0);
            var b = new Point(1, 0);
            var c = new Point(0, 1);
            var shape = _shapeFactory.CreateTriangle(a, b, c);
            var visitor = new IsRightTriangle();
            
            visitor.Visit(shape);
            Assert.AreEqual(visitor.Result, true);
        }
        
        private void IsRightTriangleNegativeTest()
        {
            var a = new Point(0, 0);
            var b = new Point(1, 0);
            var c = new Point(0, 100);
            var shape = _shapeFactory.CreateTriangle(a, b, c);
            var visitor = new IsRightTriangle();
            
            visitor.Visit(shape);
            Assert.AreEqual(visitor.Result, false);
        }
    }
}