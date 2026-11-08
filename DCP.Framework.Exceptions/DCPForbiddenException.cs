using System;

namespace DCP.Framework.Exceptions
{
    public class DCPForbiddenException : DCPBaseException
    {
        public DCPForbiddenException() : base()
        {
        }
        public DCPForbiddenException(string message) : base(message)
        {
        }
        public DCPForbiddenException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
