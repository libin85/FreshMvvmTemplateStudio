using System;
using System.Collections.Generic;
using System.Text;

namespace FreshMvvmTemplate.Core.Logging
{
    public interface ILogger
    {
        void Exception(Exception ex, string message = null, params object[] parameters);
        void Info(string message = null, params object[] parameters);
    }
}
