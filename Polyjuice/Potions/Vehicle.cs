using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// A machine, usually with wheels and an engine, used for transporting people or goods on land,
    /// especially on roads:
    /// </summary>
    public static class Vehicle
    {
        public static string Make => VehicleData.Makes.Rand();
        public static string Model => VehicleData.Models.Rand();
        public static string Trim => VehicleData.Trims.Rand();
    }
}