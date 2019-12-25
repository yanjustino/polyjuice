using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Polyjuice.Tests
{
    public static class TestHelper
    {
        
        public static void Match(string pattern, string input, string message = "")
        {
            Console.WriteLine(input);
            var match = Regex.Match(input: input, pattern: pattern);
            Assert.IsTrue(match.Success, message);
        }
    }
}