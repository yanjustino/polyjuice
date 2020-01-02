using System.Collections;
using System.Linq;
using Polyjuice.Extension;
using static System.Linq.Enumerable;
using static Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    public static class Lorem
    {
        // Private Data
        private static string[] WordsData { get; } = Read("Lorem", "Words");
        private static string[] CharactersData { get; } = Read("Lorem", "Characters");


        // Methods
        public static string Word() => WordsData.Rand();
        public static string Paragraph(int size = 3) => string.Join(" ", Sentences(size + 2.Randomize()));
        public static string[] Words(int size = 3) => WordsData.Rand(size).ToArray();
        public static string[] Sentences(int size = 3) => Range(1, size).Select(i => Sentence()).ToArray();
        public static string[] Paragraphs(int size = 3) => Range(1, size).Select(i => Paragraph()).ToArray();
        
        
        public static string Characters(int size = 255)
        {
            var sizeCount = size < 0 ? 0 : size;
            return string.Join(string.Empty, CharactersData.Rand(sizeCount).ToArray());
        }

        public static string Sentence(int size = 4)
        {
            var firstWord = string.Join(" ", Words(size + 5.Randomize(1))).Capitalize();
            var lastWords = string.Join(" ", Words(size + 5.Randomize(1)));

            return lastWords.Length > 0 ? $"{firstWord} {lastWords}." : firstWord;
        }
    }
}