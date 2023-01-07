using System.Runtime.Serialization;

namespace Week5_OOP_Advanced.HomeworkWeek5_OOP_Advanced.Ex_7
{
    internal class InvalidExceptionInputCheckAddress : Exception
    {
        public InvalidExceptionInputCheckAddress(string? message) : base(message)
        {
        }

    }
}