using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape
{
    public class Triangle: Shape
    {
        private double A;
        private double B;
        private double C;

        public Triangle(double a, double b, double c )
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public override double Squer()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new ArgumentException("There is no such triangle");
            }

            if (A > B + C || B > A + C || C > A + B)
            {
                throw new ArgumentException("There is no such triangle");
            }

            return IsTriangleRectangular()?
                RectangularTriangleSquer():
                NonRectangularTriangleSquer();
           
        }

        private double NonRectangularTriangleSquer()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 3);
        }

        private double RectangularTriangleSquer()
        {
            double[] sides = new[] { A, B, C };
            var orderSides = sides.OrderBy(n => n);
            List<double> orderedSides = orderSides.ToList<double>();
            return Math.Round(orderedSides[0] * orderedSides[1] / 2, 3);
        }

        bool IsTriangleRectangular()
        {

            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(A, 2) ||
                    Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(A, 2) ||
                        Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(A, 2))
                return true;
            else 
                return false; 
        }


    }
}
