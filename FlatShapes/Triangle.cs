using System;
using System.Collections.Generic;
using System.Linq;

namespace FlatShapes
{
    public class Triangle : FlatShape
    {
        public List<decimal> EdgeLengths { get; }

        public Triangle(double edgeA, double edgeB, double edgeC) : base()
        {
            EdgeLengths = new List<double> { edgeA, edgeB, edgeC}.Select(x => (decimal)x).ToList();
            if(EdgeLengths.Any(x => x <= 0))
                throw new Exception("Сторона должна быть больше нуля");
            if(EdgeLengths.Any(x => EdgeLengths.Where(y => y != x).Sum() <= x))
                throw new Exception("Каждая сторона должна быть короче суммы двух других");
        }

        public override double GetArea()
        {
            decimal halfPerimeter = EdgeLengths.Sum() / 2;
            decimal result = halfPerimeter;
            foreach (decimal t in EdgeLengths)
            {
                result *= halfPerimeter - t;
            }

            return Math.Sqrt((double)result);
        }

        public bool IsRight()
        {
            decimal longestEdge = EdgeLengths.Max();
            return longestEdge * longestEdge == EdgeLengths.Where(x => x != longestEdge).Sum(x => x * x);
        }
    }
}
