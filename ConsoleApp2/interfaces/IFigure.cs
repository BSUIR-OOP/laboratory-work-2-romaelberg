using System.Collections;
using System.Collections.Generic;
using ConsoleApp2.models;

namespace ConsoleApp2.interfaces
{
    public interface IFigure
    {
        public IEnumerable<Dot> GenerateDots();
    }
}