using System;

namespace DCP.Framework.Exceptions
{
    public class DCPInternalServerErrorException : DCPBaseException
    {
        public DCPInternalServerErrorException() : base()
        {
        }
        public DCPInternalServerErrorException(string message) : base(message)
        {
        }
        public DCPInternalServerErrorException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
