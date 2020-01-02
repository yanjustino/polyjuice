using System;
using System.Linq;
using System.Text;

namespace Polyjuice.Extension
{
    public static class PolyjuiceStringfy
    {
        /// <summary>
        /// Captalize the specified input.
        /// </summary>
        /// <returns>The captalize.</returns>
        /// <param name="input">Input.</param>
        public static string Capitalize(this string input)
        {
            switch (input)
            {
                case null:
                    throw new ArgumentNullException(nameof(input));
                case "":
                    throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default:
                    return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
        
        public static string Letterify(this string value)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in value.ToList())
                stringBuilder.Append(item.ToString()
                    .Replace("?", "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z".Split(',').Rand()));

            return stringBuilder.ToString();
        }        
    }
}