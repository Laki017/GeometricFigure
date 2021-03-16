using GeometricFigure.Interface;
using System;

using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GeometricFigure.Figure
{
    public class Circle : IFigure
    {
        private double _r { get; }

        public Circle(double r)
        {
            if (r <= 0) throw new ArgumentException("Radius must be a positive value");
            _r = r;
        }

        public double GetArea() => Math.PI * Math.Pow(_r, 2);

    }
}
