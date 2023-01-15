namespace Week5_OOP_Advanced.Week5_day2
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)           //acestea 2 sunt polimorfism sau method overload
        {
            return firstNumber + secondNumber;
        }

        public double Add(double firstNumber, double secondNumber) //poate fi (int firstNumber,int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
