using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace FreshMvvmTemplate.Core.Configuration
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private JObject _configSettings;

        private const string FileName = "config.json";

        private ConfigurationManager()
        {
            try
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(ConfigurationManager)).Assembly;
                var nameSpace = typeof(ConfigurationManager).Namespace;
                var stream = assembly.GetManifestResourceStream($"{nameSpace}.{FileName}");
                using (var reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    _configSettings = JObject.Parse(json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to read the confiuguration file: {ex}");
            }
        }

        public static ConfigurationManager Settings
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }

                return _instance;
            }
        }

        public string this[string name]
        {
            get
            {
                try
                {
                    var path = name.Split(':');

                    JToken node = _configSettings[path[0]];
                    for (int index = 1; index < path.Length; index++)
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
