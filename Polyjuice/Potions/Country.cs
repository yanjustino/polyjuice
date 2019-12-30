using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions
{
    /// <summary>
    /// An area of land that has its own government, army, etc.
    /// </summary>
    public static class Country
    {
        // Properties
        public static string Name => Read("Location", "Countries").Rand();
        public static string Code => Read("Location", "CountryCodes").Rand();
    }
}