using System;

namespace OpenDCP.Framework.Exceptions
{
    [Obsolete]
    public class DCPRawBadRequestException : DCPBaseException
    {
        public DCPRawBadRequestException() : base()
        {
        }
        public DCPRawBadRequestException(string message) : base(message)
        {
        }
        public DCPRawBadRequestException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
