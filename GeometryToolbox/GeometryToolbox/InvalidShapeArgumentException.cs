using System;
using System.Runtime.Serialization;

namespace GeometryToolbox
{
    public class InvalidShapeArgumentException : Exception
    {
        public InvalidShapeArgumentException()
        {
        }

        public InvalidShapeArgumentException(string message) : base(message)
        {
        }

        public InvalidShapeArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}