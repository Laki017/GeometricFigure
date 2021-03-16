using NUnit.Framework;
using GeometricFigure.Figure;
using GeometricFigure.Interface;
using System;

namespace GeometricFigureTests
{
    public class TestCircle
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Circle_Constructor_0_Or_Negative_Radius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-10));
        }

        [Test]
        public void Test_Circle_GetArea__10()
        {
            IFigure circle = new Circle(10);

            double expected = 314.1592;

            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual, 0.001);

            Assert.Pass();
        }
    }
}