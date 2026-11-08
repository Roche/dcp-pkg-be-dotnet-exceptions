using System;

namespace DCP.Framework.Exceptions
{
    public class DCPBadRequestException : DCPBaseException
    {
        public DCPBadRequestException() : base()
        {
        }
        public DCPBadRequestException(string message) : base(message)
        {
        }
        public DCPBadRequestException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
