namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_7
{
    internal class NegativeOrZeroEmployeeException : Exception
    {
        public NegativeOrZeroEmployeeException(string message) : base(message)
        {
        }
    }
}
