using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The state of being...
    /// </summary>
    public static class Gender
    {
        public static string Random => Data.Genders.Rand();
        public static string Binary => Data.BinaryGenders.Rand();

        private static class Data
        {
            public static string Genders =>
                "male female non-binary agender androgyne bi-gender pan-gender";

            public static string BinaryGenders =>
                "male female";
        }
    }
}