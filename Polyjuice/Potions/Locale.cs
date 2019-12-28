using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The word or words that a person, thing, or place is known by:
    /// </summary>
    public static class Locale
    {
        public static string Language => LocaleData.Languages.Rand();
        public static string LanguageCode => LocaleData.LanguageCodes.Rand();
    }
}