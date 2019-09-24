using System;
using GeometryToolbox.Factory;
using GeometryToolbox.Shape;
using NUnit.Framework;

namespace Tests
{
    public class CircleTest
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
            var center = new Point(0, 1);
            var shape = _shapeFactory.CreateCircle(center, 2);

            var area = shape.GetArea();
            Assert.AreEqual(area, Math.PI * 4);
        }
    }
}