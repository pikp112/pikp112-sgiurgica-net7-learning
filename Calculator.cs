
namespace Week4_HomeWork
{
    public class Calculator
    {
        public int Add(int x,int y)
        {
            return x + y;
        }

        public int Subtract(int x,int y)
        {
            return x - y;
        }

        public int Multiply(int x,int y)
        {
            return x * y;
        }

        public int Divide(int x,int y)
        {
            return x / y;
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x,y);
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
