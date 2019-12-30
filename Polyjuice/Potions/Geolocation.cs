using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    /// <summary>
    /// Technology that shows the place where you are when using the internet or a mobile phone
    /// </summary>
    public static class Geolocation
    {
        public static double Latitude => double.Parse(Read("Location", "Latitude").Rand());
        public static double Longitude => double.Parse(Read("Location", "Longitude").Rand());
    }
}