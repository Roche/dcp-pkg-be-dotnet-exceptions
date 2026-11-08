using System;

namespace DCP.Framework.Exceptions
{
    public class DCPCalculationException : DCPBaseException
    {
        public DCPCalculationException() : base()
        {
        }
        public DCPCalculationException(string message) : base(message)
        {
        }
        public DCPCalculationException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
