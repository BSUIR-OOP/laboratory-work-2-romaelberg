using System;
using System.Collections.Generic;

namespace ConsoleApp2.models
{
    public class Trapezoid: Figure
    {
        protected double LeftSide;

        protected int RightSide;

        protected int BottomSide;
        protected int TopSide;


        public Trapezoid(int leftSide, int rightSide, int topSide, int bottomSide)
        {
            LeftSide = leftSide;
            RightSide = rightSide;
            TopSide = topSide;
            BottomSide = bottomSide;
        }

        private int GetHeight()
        {
            return (int)(Math.Sqrt(LeftSide * LeftSide-(((BottomSide-TopSide)*(BottomSide-TopSide)+LeftSide*LeftSide-RightSide*RightSide)/(2*(BottomSide-TopSide)))));
        }
        public override IEnumerable<Dot> GenerateDots()
        {
            var height = GetHeight();
            var topSideStartPosition = (int) Math.Sqrt(LeftSide * LeftSide - height*height);
            var dots = new List<Dot>
            {
                new(new Coordinate(0, 0)), // Bottom side
                new(new Coordinate(topSideStartPosition, height)),
                new(new Coordinate(topSideStartPosition + TopSide, height)),
                new(new Coordinate(BottomSide, 0))
            };
            return dots;
        }
        public override string ToString()
        {
            return "Trapezoid";
        }
    }
}