using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Polyjuice.Extension
{
    /// <summary>
    /// PolyjuiceRandomizer
    /// Extension Methods (C# Programming Guide)
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
    /// </summary>
    internal static class PolyjuiceRandomizer
    {
        private static Random Random => new Random();

        public static string Rand(this string[] values)
        {
            var index = values.Count().Randomize();
            return values[index];
        }
        
        public static string[] Rand(this string[] values, int count)
        {
            return Enumerable.Range(1, count).Select(i => Rand(values)).ToArray();            
        }        

        public static int Rand(this int[] values)
        {
            var index = values.Count().Randomize();
            return values[index];
        }        

        public static double[] Rand(this double[,] values)
        {
            var index = values.GetLength(0).Randomize();

            return new[]
            {
                (double) values.GetValue(index, 0),
                (double) values.GetValue(index, 1)
            };
        }

        public static string Rand(this string value, char separator = ' ')
        {
            return value.Split(separator).Rand();
        }

        public static int Randomize(this int max, int min = 0)
        {
            return Random.Next(min, max);
        }
    }
}