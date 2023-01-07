namespace Week5_OOP_Advanced
{
    sealed class Rectangle : Shape
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(string color, double width, double height)
        {
            Color=color;
            Width=width;
            Height=height;
        }
        public override double CalculateArea()
        {
            return Area=Width*Height;
        }
        public override double GetPerimeter()
        {
            return Perimeter=2*(Width+Height);
        }
        public string GetPerimter(string unit)
        {
            return $"Perimeter: {Perimeter} {unit}.";
        }
    }
}
