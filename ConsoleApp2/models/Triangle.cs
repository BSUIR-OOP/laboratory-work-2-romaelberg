using System;
using System.Collections.Generic;

namespace ConsoleApp2.models
{
    public class Triangle: Figure
    {
        protected int FirstSide { get; set; }
        protected int SecondSide { get; set; }
        protected int ThirdSide { get; set; }

        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        private int GetPoluPerimeter()
        {
            return (FirstSide + SecondSide + ThirdSide) / 2;
        }
        private int GetHeight()
        {
            var poluperimeter = GetPoluPerimeter();
            return (int) ((2 / FirstSide) * Math.Sqrt(poluperimeter * (poluperimeter - FirstSide) *
                                                      (poluperimeter - SecondSide) * (poluperimeter - ThirdSide)));
        }
        public override IEnumerable<Dot> GenerateDots()
        {
            var height = GetHeight();
            var secondSidePosition = (int) Math.Sqrt(SecondSide * SecondSide - height * height);
            var dots = new List<Dot>
            {
                new(new Coordinate(0, 0)),
                new(new Coordinate(FirstSide, 0)),
                new(new Coordinate(secondSidePosition, height))
            };
            return dots;
        }
        public override string ToString()
        {
            return "Triangle";
        }
    }
}