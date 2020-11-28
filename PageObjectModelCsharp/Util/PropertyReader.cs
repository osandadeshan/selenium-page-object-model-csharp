using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PageObjectModelCsharp.Util
{
    internal static class PropertyReader
    {
        public static string GetPropertyValue(String propertyName)
        {
            var path = Assembly.GetCallingAssembly().CodeBase;
            if (path == null) return null;
            var actualPath = path.Substring(0, path.LastIndexOf("bin", StringComparison.Ordinal));
            var projectPath = new Uri(actualPath).LocalPath;
            var reportPath = projectPath + "\\App.properties";
            var data = File.ReadAllLines(reportPath)
                .ToDictionary(row => row.Split('=')[0], 
                    row => string.Join("=", row.Split('=').Skip(1).ToArray()));
            return data[propertyName];
        }
    }
}