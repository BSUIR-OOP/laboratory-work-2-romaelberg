using System.Collections;
using System.Collections.Generic;
using ConsoleApp2.interfaces;

namespace ConsoleApp2.models
{
    public abstract class Figure: IFigure
    {
        public abstract IEnumerable<Dot> GenerateDots();
    }
}