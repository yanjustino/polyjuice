using System.Linq;
using System.Text;

namespace Polyjuice.Extension
{
    /// <summary>
    /// PolyjuiceNumerify
    /// Extension Methods (C# Programming Guide)
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
    /// </summary>
    internal static class PolyjuiceNumerify
    {
        public static string Numerify(this string value)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in value.ToList())
                stringBuilder.Append(item.ToString().Replace("#", 10.Randomize().ToString()));

            return stringBuilder.ToString();
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