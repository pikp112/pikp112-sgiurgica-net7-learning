namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }
        public abstract double CalculateArea();
        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

    }
}
