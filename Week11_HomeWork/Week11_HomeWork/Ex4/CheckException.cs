using System.Runtime.Serialization;

namespace Week11_HomeWork.Ex4
{
    [Serializable]
    internal class CheckException : Exception
    {
        public CheckException()
        {
        }

        public CheckException(string? message) : base(message)
        {
        }

        public CheckException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CheckException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}