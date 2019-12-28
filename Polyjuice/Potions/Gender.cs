using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The state of being...
    /// </summary>
    public static class Gender
    {
        private static string Genders => "male female non-binary agender androgyne bi-gender pan-gender";
        private static string BinaryGenders => "male female";
        
        
        public static string Random => Genders.Rand();
        public static string Binary => BinaryGenders.Rand();
    }
}