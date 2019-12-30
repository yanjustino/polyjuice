using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Polyjuice.Potions.Data
{
    internal static class DataReader
    {
        public static string[] Read(string data)
        {
            var tokens = data.Split('_');
            return Read(tokens[0], tokens[1]);
        }

        public static string[] Read(string collection, string data)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var values = new List<string>();
            var resourceName = FormatResourceName(assembly, $"Potions/Data/{collection}/{data}.data");

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream ?? throw new ArgumentException("data file not found")))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                        values.Add(line);
                }
            }

            return values.ToArray();
        }

        private static string FormatResourceName(Assembly assembly, string resourceName)
        {
            return assembly.GetName().Name + "." + resourceName.Replace(" ", "_")
                       .Replace("\\", ".")
                       .Replace("/", ".");
        }
    }
}