using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The word or words that a person, thing, or place is known by:
    /// </summary>
    public static class Name
    {
        public static string FirstName => NameData.FirstNames.Rand();
        public static string Prefix => NameData.Prefix.Rand();
        public static string LastName => NameData.LastNames.Rand();
        public static string FullName => $"{FirstName} {LastName}";
        public static string NameWithPrefix => $"{NameData.Prefix.Rand()} {FirstName} {LastName}";
    }
}