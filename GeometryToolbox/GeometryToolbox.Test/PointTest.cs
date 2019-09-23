using System;
using GeometryToolbox.Factory;
using GeometryToolbox.Shape;
using NUnit.Framework;

namespace Tests
{
    public class PointTest
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(Double.MaxValue, Double.MaxValue)]
        [TestCase(Double.MaxValue, Double.MinValue)]
        [TestCase(Double.MinValue, Double.MaxValue)]
        [TestCase(Double.MinValue, Double.MinValue)]
        public void EqualTest(double x, double y)
        {
            var pLeft = new Point(x, y);
            var pRight = new Point(y, x);
            
            if (x == y)
            {
                Assert.True(pLeft == pRight);
                Assert.False(pLeft != pRight);
                Assert.True(pLeft.Equals(pRight));
                Assert.True(pLeft.Equals((object)pRight));
                return;
            }

            Assert.True(pLeft != pRight);
            Assert.False(pLeft == pRight);
            Assert.False(pLeft.Equals(pRight));
            Assert.False(pLeft.Equals((object)pRight));
        }
    }
}