using System;

namespace OpenDCP.Framework.Exceptions
{
    public class DCPUnauthorizedException : DCPBaseException
    {
        public DCPUnauthorizedException() : base()
        {
        }
        public DCPUnauthorizedException(string message) : base(message)
        {
        }
        public DCPUnauthorizedException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
