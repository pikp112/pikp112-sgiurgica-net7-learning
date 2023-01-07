namespace Week5_OOP_Advanced
{
    public class Circle : Shape
    {
        private double Radius { get; set; }
        private double PI = 3.1415926535897931;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return PI*Math.Pow(Radius,2);
        }

        public override double GetPerimeter()
        {
            return 2*PI*Radius;
        }
    }
}
