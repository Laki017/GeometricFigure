using GeometricFigure.Interface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace GeometricFigure.Figure
{
    public class Triangle : IFigure
    {
        private double _sideA { get; }
        private double _sideB { get; }
        private double _sideC { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Sides of a triangle must be a positive value");
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            if (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC ||
                _sideA * _sideA + _sideC * _sideC == _sideB * _sideB ||
                _sideC * _sideC + _sideB * _sideB == _sideA * _sideA) return true;
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
    }
}
