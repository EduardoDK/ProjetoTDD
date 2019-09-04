using System;
using System.Runtime.Serialization;

namespace MatematicaTeste
{
    [Serializable]
    internal class ArgumentOutOfRangeExeception : Exception
    {
        public ArgumentOutOfRangeExeception()
        {
        }

        public ArgumentOutOfRangeExeception(string message) : base(message)
        {
        }

        public ArgumentOutOfRangeExeception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentOutOfRangeExeception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}