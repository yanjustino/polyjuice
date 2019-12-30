using System.Collections.Generic;
using System.Linq;
using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The number of a building and the name of the street, city, etc. where it is
    /// </summary>
    public static class Address
    {
        // Private Data
        private static IEnumerable<string> CityPrefixes { get; } = new []{"New", "Lake", "Port"};
        private static IEnumerable<string> CompassDirections { get; } = new [] {"North", "East", "West", "South"};        
        
        
        // Properties
        public static string State => Read("Address","States").Rand();
        public static string StateAbbr => Read("Address","StatesAbbr").Rand();
        public static string ZipCode => "#####-####".Numerify();
        public static string BuildingNumber => "### #####".Rand().Numerify();
        public static string Location => $"{BuildingNumber} {StreetName}";

        
        //  Methods
        public static string StreetName
        {
            get
            {
                switch (2.Randomize())
                {
                    case 0:
                        return $"{Name.LastName} {Read("Address", "StreetSufix").Rand()}";
                    case 1:
                        return $"{Name.FirstName} {Read("Address","StreetSufix").Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }

        public static string City
        {
            get
            {
                var prefix = CompassDirections.Union(CityPrefixes).ToArray();
                
                switch (4.Randomize())
                {
                    case 0:
                        return $"{prefix.Rand()} {Name.FirstName}";
                    case 1:
                        return $"{prefix.Rand()} {Name.FirstName} {Read("Address","CitySufix").Rand()}";
                    case 2:
                        return $"{Name.FirstName} {Read("Address","CitySufix").Rand()}";
                    case 3:
                        return $"{Name.LastName} {Read("Address","CitySufix").Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }
    }
}