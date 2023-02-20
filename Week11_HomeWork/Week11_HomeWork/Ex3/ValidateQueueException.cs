using System.Runtime.Serialization;

namespace Week11_HomeWork.Ex3
{
    [Serializable]
    internal class ValidateQueueException : Exception
    {
        public ValidateQueueException(string? message) : base(message)
        {
        }

    }
}