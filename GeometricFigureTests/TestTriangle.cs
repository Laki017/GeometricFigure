using NUnit.Framework;
using GeometricFigure.Figure;
using GeometricFigure.Interface;
using System;
using System.Diagnostics;

namespace GeometricFigureTests
{
    public class TestTriangle
    {
        [SetUp] 
        public void Setup()
        {
        }

        [Test]
        public void Test_Triangle_Constructor_0_Or_Negative_Side()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(5, 0, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(5, 4, 0));
        }

        [Test]
        public void Test_Triangle_GetArea_Side_5_4_3()
        {
            IFigure triangle = new Triangle(5, 4, 3);
            double expected = 6;
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, 0.001);
        }
        [Test]
        public void Test_Triangle_IsRightTriangle()
        {
            Triangle triangle = new Triangle(5, 4, 3);

            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}