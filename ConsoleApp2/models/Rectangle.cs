using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2.models
{
    public class Rectangle: Figure
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override IEnumerable<Dot> GenerateDots()
        {
            var dots = new List<Dot>
            {
                new(new Coordinate(0, 0)),
                new(new Coordinate(Width, 0)),
                new(new Coordinate(0, Height)),
                new(new Coordinate(Width, Height))
            };
            return dots;
        }
        public override string ToString()
        {
            return "Rectangle";
        }
    }
}