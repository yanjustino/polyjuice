using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions
{
    /// <summary>
    /// A machine, usually with wheels and an engine, used for transporting people or goods on land,
    /// especially on roads:
    /// </summary>
    public static class Vehicle
    {
        public static string Make => Read("Vehicle", "VehicleMakes").Rand();
        public static string Model => Read("Vehicle", "VehicleModels").Rand();
        public static string Trim => Read("Vehicle", "VehicleTrims").Rand();
    }
}