namespace ConsoleApp2.models
{
    public class Circle
    {
        protected double Radius { get; set; }

        protected Circle(double radius)
        {
            Radius = radius;
        }
    }
}