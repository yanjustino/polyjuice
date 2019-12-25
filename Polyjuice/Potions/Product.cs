using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public class Product
    {
        public static string Name => $"{Data.Adjectives.Rand()} {Data.Nouns.Rand()} {Data.B1.Rand()}";

        private static class Data
        {
            public static string[] B1 { get; } =
            {
                "So",
                "Lu",
                "Sir",
                "Bri",
                "Reu",
                "Gen",
                "Fin",
                "Pana",
                "Sine",
                "Co",
                "Aqua",
                "Am",
                "Ca",
                "Cyg",
                "Tech",
                "After",
                "Sub",
                "One",
                "Tri",
            };

            public static string[] Nouns { get; } =
            {
                "Filter",
                "Compressor",
                "System",
                "Viewer",
                "Mount",
                "Case",
                "Adapter",
                "Amplifier",
                "Bridge",
                "Bracket",
                "Kit",
                "Transmitter",
                "Receiver",
                "Tuner",
                "Controller",
                "Component",
                "Lifter",
                "Ferrule",
                "Dummy Groove",
            };

            public static string[] Adjectives { get; } =
            {
                "Air",
                "Gel",
                "Auto",
                "Power",
                "Tag",
                "Audible",
                "HD",
                "GPS",
                "Portable",
                "Disc",
                "Electric",
                "Performance",
                "Side",
                "Video",
                "Input",
                "Output",
                "Direct",
                "Remote",
                "Digital",
            };
        }
    }
}