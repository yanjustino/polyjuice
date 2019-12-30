using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions
{
    /// <summary>
    /// The word or words that a person, thing, or place is known by:
    /// </summary>
    public static class Name
    {
        // Private Data
        public static string Prefixes => "Mr. Ms.";
        
        
        // Propeties
        public static string FirstName => Read("Name", "FirstNames").Rand();
        public static string Prefix => Prefixes.Rand();
        public static string LastName => Read("Name", "LastNames").Rand();
        public static string FullName => $"{FirstName} {LastName}";
        public static string NameWithPrefix => $"{Prefixes.Rand()} {FirstName} {LastName}";
    }
}