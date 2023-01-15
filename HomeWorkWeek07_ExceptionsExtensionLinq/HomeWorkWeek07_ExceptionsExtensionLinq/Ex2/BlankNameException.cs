using System.Runtime.Serialization;

namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex2
{
    internal class BlankNameException : Exception
    {
        public BlankNameException(string? message) : base(message)
        {
        }

    }
}