using System;

namespace DCP.Framework.Exceptions
{
    public class DCPDataSourceException : DCPBaseException
    {
        public DCPDataSourceException() : base()
        {
        }
        public DCPDataSourceException(string message) : base(message)
        {
        }
        public DCPDataSourceException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
