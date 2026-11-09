using System;

namespace OpenDCP.Framework.Exceptions
{
    public class DCPBaseException : Exception
    {
        public DCPBaseException() : base()
        {
        }
        public DCPBaseException(string message) : base(message)
        {
        }
        public DCPBaseException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
