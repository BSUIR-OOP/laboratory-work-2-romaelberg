namespace ConsoleApp2.models
{
    public class Coordinate
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public Coordinate(int x, int y)
        {
            XAxis = x;
            YAxis = y;
        }
    }
}