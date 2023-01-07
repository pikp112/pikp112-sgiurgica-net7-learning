namespace Week5_OOP_Advanced
{
    interface IShape
    {
        double CalculateArea();
        string CalculateArea(string unit);
        double Area { get; }
    }
}
