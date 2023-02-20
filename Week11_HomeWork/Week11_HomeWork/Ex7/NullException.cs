using System.Runtime.Serialization;

namespace Week11_HomeWork.Ex7
{
    [Serializable]
    internal class NullException : Exception
    {
        public NullException(string? message) : base(message)
        {
        }

    }
}