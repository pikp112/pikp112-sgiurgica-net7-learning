namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_3
{
    sealed class Circle : Shape
    {
        private double Radius { get; set; }
        public double Circumference { get => Perimeter; set => Perimeter=value; }
        public Circle(string color, double radius)
        {
            Color=color;
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return ConstValues.Pi*Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return Circumference=2*ConstValues.Pi*Radius;
        }

        public string GetPerimeter(string unit)
        {
            return $"Circumferince: {GetPerimeter()} {unit}.";
        }
    }
}
