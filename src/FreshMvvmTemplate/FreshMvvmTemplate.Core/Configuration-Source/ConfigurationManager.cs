using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace FreshMvvmTemplate.Core.Configuration
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private readonly JObject _configSettings;
        private const string FileName = "config.json";

        private ConfigurationManager()
        {
            try
            {
                var assembly = typeof(ConfigurationManager).GetTypeInfo().Assembly;
                var nameSpace = typeof(ConfigurationManager).Namespace;
                var stream = assembly.GetManifestResourceStream($"{nameSpace}.{FileName}");
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var json = reader.ReadToEnd();
                        _configSettings = JObject.Parse(json);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to read the configuration file: {ex}");
            }
        }

        public static ConfigurationManager Settings => _instance ?? (_instance = new ConfigurationManager());

        public string this[string name]
        {
            get
            {
                try
                {
                    var path = name.Split(':');
                    var node = _configSettings[path[0]];
                    for (var index = 1; index < path.Length; index++)
                    {
                        node = node[path[index]];
                    }
                    return node.ToString();
                }
                catch (Exception)
                {
                    Debug.WriteLine($"Unable to retrieve configuration '{name}'");
                    return string.Empty;
                }
            }
        }
    }
}
