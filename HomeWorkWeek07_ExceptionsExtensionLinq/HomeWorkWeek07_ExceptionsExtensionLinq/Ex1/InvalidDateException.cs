using System.Runtime.Serialization;

namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex1
{
    [Serializable]
    internal class InvalidDateException : Exception
    {
        public InvalidDateException(string? message) : base(message)
        {
        }

    }
}