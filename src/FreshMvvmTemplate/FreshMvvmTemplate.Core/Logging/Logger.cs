using Microsoft.AppCenter.Crashes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FreshMvvmTemplate.Core.Logging
{
    public class Logger : ILogger
    {
        public void Exception(Exception ex, string message = null, params object[] parameters)
        {
            var stringParameters = JsonConvert.SerializeObject(parameters);
            var properties = new Dictionary<string, string>
            {
                { "Message", message },
                { "Parameters", stringParameters}
            };
            Crashes.TrackError(ex, properties);
            Debug.WriteLine("****Exception Thrown****");
            Debug.WriteLine(message);
            Debug.WriteLine(ex);
            Debug.WriteLine(stringParameters);
            Debug.WriteLine("************************");
        }

        public void Info(string message = null, params object[] parameters)
        {
            var stringParameters = JsonConvert.SerializeObject(parameters);
            Debug.WriteLine("****Debug Information****");
            Debug.WriteLine(message);
            Debug.WriteLine(stringParameters);
            Debug.WriteLine("*************************");
        }
    }
}
