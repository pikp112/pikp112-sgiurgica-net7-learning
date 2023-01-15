using System.Drawing;

namespace Week5_OOP_Advanced
{
    sealed class Circle : IShape, IColor
    {
        private double Radius { get; set; }
        public string Color { get; set; }
        public double Area
        {
            get
            {
                return CalculateArea();
            }
        }
        public Circle(double radius)
        {
            Color="Black";
            Radius=radius;
        }
        public Circle(double radius, string color)
        {
            Color=color;
            Radius=radius;
        }

        public double CalculateArea()
        {
            return ConstantValues.Pi*Math.Pow(Radius, 2);
        }
        public string CalculateArea(string unit)
        {
            //Area=ConstantValues.Pi*Math.Pow(Radius, 2);
            return $"Area: {CalculateArea()} {unit}.";
        }
    }
}