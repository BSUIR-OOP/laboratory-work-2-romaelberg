using System.Collections.Generic;

namespace ConsoleApp2.models
{
    public class Line: Figure
    {
        private int Width { get; set; }

        public Line(int width)
        {
            Width = width;
        }

        public override IEnumerable<Dot> GenerateDots()
        {
            var dots = new List<Dot>
            {
                new(new Coordinate(0, 0)),
                new(new Coordinate(Width, 0))
            };
            return dots;
        }
        public override string ToString()
        {
            return "Line";
        }
    }
}