namespace Week5_OOP_Advanced
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
           return Width*Height;
        }

        public override double GetPerimeter()
        {
            return 2*(Width+Height);
        }
    }
}
