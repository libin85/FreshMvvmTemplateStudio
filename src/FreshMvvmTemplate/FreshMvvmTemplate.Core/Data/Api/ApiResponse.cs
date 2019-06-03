using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FreshMvvmTemplate.Core.Services.Rest
{
    public class ApiResponse<T> : IDisposable
    {
        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string UserMessage { get; set; }
        public string TechnicalMessage { get; set; }
        public T Response { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
