namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_3
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
            return Width*Height;
        }
        public override double GetPerimeter()
        {
            return 2*(Width+Height);
        }
        public string GetPerimter(string unit)
        {
            return $"Perimeter: {this.GetPerimeter()} {unit}.";
        }
    }
}
