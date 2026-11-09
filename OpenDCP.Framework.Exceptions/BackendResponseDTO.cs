using System;

namespace OpenDCP.Framework.Exceptions
{
    public class BackendResponseDTO
    {
        public string ErrorId { get; set; } = new Guid().ToString();
        public string Message { get; set; } = string.Empty;
        public string StackTrace { get; set; } = string.Empty;
    }
}
