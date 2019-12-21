using System;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Gender
    {
        public static string Random => Genders.Rand();
        public static string Binary => BinaryGenders.Rand();

        private static string Genders =>
            "male female non-binary agender androgyne bi-gender pan-gender";
        
        private static string BinaryGenders =>
            "male female";    
    }
}