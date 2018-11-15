using System;

namespace Brilliance.WebAPITest.Helper
{
    public class NotFoundAPIException : Exception
    {
        public NotFoundAPIException()
        {
        }

        public NotFoundAPIException(string message) : base(message)
        {
        }

        public NotFoundAPIException(string message, Exception inner) : base(message, inner)
        {
        }

        public NotFoundAPIException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}