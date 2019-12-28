using System.Linq;
using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The number of a building and the name of the street, city, etc. where it is
    /// </summary>
    public static class Address
    {
        public static string State => AddressData.States.Rand();
        public static string StateAbbr => AddressData.StatesAbbr.Rand();
        public static string ZipCode => "#####-####".Numerify();
        public static string BuildingNumber => "### #####".Rand().Numerify();
        public static string Location => $"{BuildingNumber} {StreetName}";

        
        public static string StreetName
        {
            get
            {
                switch (2.Randomize())
                {
                    case 0:
                        return $"{Name.LastName} {AddressData.StreetSufix.Rand()}";
                    case 1:
                        return $"{Name.FirstName} {AddressData.StreetSufix.Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }

        public static string City
        {
            get
            {
                var prefix = AddressData.CompassDirections.Union(AddressData.CityPrefixes).ToArray();
                
                switch (4.Randomize())
                {
                    case 0:
                        return $"{prefix.Rand()} {Name.FirstName}";
                    case 1:
                        return $"{prefix.Rand()} {Name.FirstName} {AddressData.CitySufix.Rand()}";
                    case 2:
                        return $"{Name.FirstName} {AddressData.CitySufix.Rand()}";
                    case 3:
                        return $"{Name.LastName} {AddressData.CitySufix.Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }
    }
}