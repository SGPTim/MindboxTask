using System;
using GeometryToolbox.Factory;
using GeometryToolbox.Shape;
using GeometryToolbox.Shape.Query;
using NUnit.Framework;

namespace Tests
{
    public class GetAreaQueryTest
    {
        private ShapeFactory _shapeFactory;

        [SetUp]
        public void Setup()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        public void GetAreaRectangleTest()
        {
            var a = new Point(1, 0);
            var b = new Point(0, 1);
            var shape = _shapeFactory.CreateRectangle(a, b);
            var visitor = new GetAreaQuery();

            visitor.Visit(shape);
            Assert.AreEqual(visitor.Result, 1);
        }

        [Test]
        public void GetAreaCircleTest()
        {
            var center = new Point(0, 1);
            var shape = _shapeFactory.CreateCircle(center, 2);
            var visitor = new GetAreaQuery();

            visitor.Visit(shape);
            Assert.AreEqual(visitor.Result, Math.PI * 4);
        }

        private void GetAreaTriangleTest()
        {
            var a = new Point(0, 0);
            var b = new Point(1, 0);
            var c = new Point(0, 1);
            var shape = _shapeFactory.CreateTriangle(a, b, c);
            var visitor = new GetAreaQuery();
            
            visitor.Visit(shape);
            Assert.AreEqual(visitor.Result, 0.5);
        }
    }
}