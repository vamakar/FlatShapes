using System;

namespace FlatShapes
{
    public class Circle : FlatShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            if (Radius <= 0)
                throw new Exception("Радиус должен быть больше нуля");
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
