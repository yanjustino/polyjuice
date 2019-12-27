using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// An area of land that has its own government, army, etc.
    /// </summary>
    public static class Country
    {
        public static string Name => CountryData.Countries.Rand();
        public static string Code => CountryData.CountryCodes.Rand();

    }
}