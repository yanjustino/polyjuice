using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// Technology that shows the place where you are when using the internet or a mobile phone
    /// </summary>
    public static class Geolocation
    {
        public static double Latitude => GeolocationData.Location.Rand()[0];
        public static double Longitude => GeolocationData.Location.Rand()[1];
    }
}