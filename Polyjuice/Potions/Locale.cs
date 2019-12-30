using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The word or words that a person, thing, or place is known by:
    /// </summary>
    public static class Locale
    {
        public static string Language => Read("Location", "Languages").Rand();
        public static string LanguageCode => Read("Location", "LanguageCodes").Rand();
    }
}