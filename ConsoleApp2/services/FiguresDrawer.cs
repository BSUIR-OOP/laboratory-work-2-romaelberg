using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp2.interfaces;
using ConsoleApp2.models;

namespace ConsoleApp2.services
{
    public class FiguresDrawer
    {
        private readonly List<Figure> _figuresList = new List<Figure>();
        public FiguresDrawer()
        {
            FillFiguresCollection();
        }

        public void AddToFigureCollection(Figure figure)
        {
            _figuresList.Add(figure);
        }
        private void FillFiguresCollection()
        {
            _figuresList.Add(new Rectangle(10, 12));
            _figuresList.Add(new Square(10));
            _figuresList.Add(new Trapezoid(10, 12, 10, 20));
            _figuresList.Add(new Line(10));
            _figuresList.Add(new Triangle(10, 12, 15));
        }

        public void PrintFigureDots(IEnumerable<Dot> dots)
        {
            foreach (var dot in dots)
            {
                Console.Write("("+dot.DotCoordinate.XAxis + ", " + dot.DotCoordinate.YAxis + ") ");
            }
        }
        public void PrintFiguresCollection()
        {
            foreach (IFigure figure in _figuresList)
            {
                var fugireDots = figure.GenerateDots();
                Console.Write(figure + "Dots: ");
                PrintFigureDots(fugireDots);
                Console.WriteLine();
                
            }
        }
    }
}