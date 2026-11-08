using System;

namespace DCP.Framework.Exceptions
{
    public class DCPNotFoundException : DCPBaseException
    {
        public DCPNotFoundException() : base()
        {
        }
        public DCPNotFoundException(string message) : base(message)
        {
        }
        public DCPNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
