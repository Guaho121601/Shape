using System;

namespace Shape
{
    public class Circule: Shape
    {
        double radius;

        public Circule(double r)
        {
            radius = r;
        }

        public override double Squer()
        {
            if (radius < 0)
            { 
                throw new Exception("Radius cant be negative");  
            }
            return Math.PI * Math.Pow(radius, 2); 
        }

    }
}
