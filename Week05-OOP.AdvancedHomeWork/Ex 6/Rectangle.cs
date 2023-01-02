namespace Week5_OOP_Advanced
{
    sealed class Rectangle : IShape, IColor
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public string Color { get; set; }
        public double Area { get; private set; }
        public Rectangle(double width, double height)
        {
            Width=width;
            Height=height;
            Color="Black";
        }
        public Rectangle(double width, double height, string color)
        {
            Color=color;
            Width=width;
            Height=height;
        }

        public double CalculateArea()
        {
            return Area= Width*Height;
        }
        public string CalculateArea(string unit)
        {
            return $"Area: {CalculateArea()} {unit}.";
        }
    }
}
