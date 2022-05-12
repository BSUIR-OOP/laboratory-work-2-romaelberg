using System.Collections.Generic;

namespace ConsoleApp2.models
{
    public class Square: Figure
    {
        protected int SideLength { get; set; }

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public override IEnumerable<Dot> GenerateDots()
        {
            var dots = new List<Dot>
            {
                new(new Coordinate(0, 0)),
                new(new Coordinate(SideLength, 0)),
                new(new Coordinate(0, SideLength)),
                new(new Coordinate(SideLength, SideLength))
            };
            return dots;
        }

        public override string ToString()
        {
            return "Square";
        }
    }
}