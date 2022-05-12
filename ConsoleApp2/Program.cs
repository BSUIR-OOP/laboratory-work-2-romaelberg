using System;
using ConsoleApp2.services;
using ConsoleApp2.models;

namespace ConsoleApp2
{
    class FiguresFactory 
    {
        public getFigure(string fig_type) {
            var getters = new Dictionary<string, Figure>() {
                { 'square', this.getSquare },
                { 'rectangle',  this.getRectangle},
                { 'line', this.getLine },
                { 'triangle', this.getTriangle },
                { 'trapezoid', this.getTrapezoid },
            };
            return getters[fig_type];
        }
        private Rectangle getRectangle(int[] params) {
            return new Rectangle(params[0], params[1]);
        }
        private Square getSquare(int[] params) {
            return new Rectangle(params[0]);
        }
        private Line getLine(int[] params) {
            return new Rectangle(params[0]);
        }
        private Trapezoid getTrapezoid(int[] params) {
            return new Trapezoid(params[0], params[1], params[2], params[3]);
        }
        private Triangle getTriangle(int[] params) {
            return new Trapezoid(params[0], params[1], params[2]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var figuresDrawer = new FiguresDrawer();
            var factory = new FiguresFactory();
            while (true) {
                string mystring = null;
                Console.WriteLine("Enter your input : ");
                mystring = Console.ReadLine();
                switch (mystring) 
                {
                    case "fill":
                        figuresDrawer.FillFiguresCollection();
                        figuresDrawer.PrintFiguresCollection();
                        break;
                    case "add":
                        Console.WriteLine("Enter figure type: ");
                        string figureType = Console.ReadLine();
                        Console.WriteLine("Enter figure params");
                        string figureParams = Console.ReadLine();
                        string[] figureParamsList = figureParams.Split(" ");
                        int[] figuresParamsIntList = Array.ConvertAll(figureParamsList, s => int.Parse(s));
                        var figureBuilder = factory.getFigure();
                        figuresDrawer.AddToFigureCollection(figureBuilder(figuresParamsIntList));
                    case "print":
                        figuresDrawer.PrintFiguresCollection();
                }
            }
        }
    }
}