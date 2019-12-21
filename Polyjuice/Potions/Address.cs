using System.Linq;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Address
    {
        public static string State => States.Rand();
        public static string StateAbbr => StatesAbbr.Rand();
        public static string ZipCode => "#####-####".Numerify();

#if NETSTANDARD
        public static string StreetName
        {
            get
            {
                switch (2.Randomize())
                {
                    case 0:
                        return $"{Name.LastName} {StreetSufix.Rand()}";
                    case 1:
                        return $"{Name.FirstName} {StreetSufix.Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }
#elif NETSTANDARD2_1
        public static string StreetName =>
             switch (2.Randomize())
            {
                case 0 : $"{Name.LastName} {StreetSufix.Rand()}",
                1 => $"{Name.FirstName} {StreetSufix.Rand()}",
                _ => string.Empty
            };   
#endif

#if NETSTANDARD
        public static string City
        {
            get
            {
                var prefix = CompassDirections.Union(CityPrefixes);

                switch (4.Randomize())
                {
                    case 0:
                        return $"{prefix} {Name.FirstName}";
                    case 1:
                        return $"{prefix} {Name.FirstName}{CitySufix.Rand()}";
                    case 2:
                        return $"{Name.FirstName}{CitySufix.Rand()}";
                    case 3:
                        return $"{Name.LastName}{CitySufix.Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }
#elif NETSTANDARD2_1   
        public static string City
        {
            get
            {
                var prefix = CompassDirections.Union(CityPrefixes);

                return 4.Randomize() switch
                {
                    0 => $"{prefix} {Name.FirstName}",
                    1 => $"{prefix} {Name.FirstName}{CitySufix.Rand()}",
                    2 => $"{Name.FirstName}{CitySufix.Rand()}",
                    3 => $"{Name.LastName}{CitySufix.Rand()}",
                    _ => string.Empty
                };
            }
        }  
#endif      

        public static string Location => $"{"###".Numerify()} {StreetName}";

        private static string[] StatesAbbr { get; } =
        {
            "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI",
            "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
            "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA",
            "WV", "WI", "WY"
        };

        private static string[] States { get; } =
        {
            "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
            "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
            "Louisiana",
            "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana",
            "Nebraska", "Nevada",
            "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
            "Oklahoma", "Oregon",
            "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
            "Virginia",
            "Washington", "West Virginia", "Wisconsin", "Wyoming"
        };

        private static string[] CompassDirections { get; } =
        {
            "North", "East", "West", "South"
        };

        private static string[] CityPrefixes { get; } =
        {
            "New", "Lake", "Port"
        };

        private static string[] CitySufix { get; } =
        {
            "town", "ton", "land", "ville", "berg", "burgh", "borough", "bury", "view", "port",
            "mouth", "stad", "furt", "chester", "mouth", "fort", "haven", "side", "shire"
        };

        private static string[] StreetSufix { get; } =
        {
            "Alley", "Avenue", "Branch", "Bridge", "Brook", "Brooks", "Burg", "Burgs", "Bypass", "Camp",
            "Canyon", "Cape", "Causeway", "Center", "Centers", "Circle", "Circles", "Cliff", "Cliffs", "Club", "Common",
            "Corner",
            "Corners", "Course", "Court", "Courts", "Cove", "Coves", "Creek", "Crescent", "Crest", "Crossing",
            "Crossroad", "Curve",
            "Dale", "Dam", "Divide", "Drive", "Drives", "Estate", "Estates", "Expressway", "Extension", "Extensions",
            "Fall", "Falls",
            "Ferry", "Field", "Fields", "Flat", "Flats", "Ford", "Fords", "Forest", "Forge", "Forges", "Fork", "Forks",
            "Fort",
            "Freeway", "Garden", "Gardens", "Gateway", "Glen", "Glens", "Green", "Greens", "Grove", "Groves", "Harbor",
            "Harbors",
            "Haven", "Heights", "Highway", "Hill", "Hills", "Hollow", "Inlet", "Island", "Islands", "Isle", "Junction",
            "Junctions",
            "Key", "Keys", "Knoll", "Knolls", "Lake", "Lakes", "Land", "Landing", "Lane", "Light", "Lights", "Loaf",
            "Lock", "Locks",
            "Lodge", "Loop", "Mall", "Manor", "Manors", "Meadow", "Meadows", "Mews", "Mill", "Mills", "Mission",
            "Motorway", "Mount",
            "Mountain", "Mountains", "Neck", "Orchard", "Oval", "Overpass", "Park", "Parks", "Parkway", "Parkways",
            "Pass", "Passage",
            "Path", "Pike", "Pine", "Pines", "Place", "Plain", "Plains", "Plaza", "Point", "Points", "Port", "Ports",
            "Prairie",
            "Radial", "Ramp", "Ranch", "Rapid", "Rapids", "Rest", "Ridge", "Ridges", "River", "Road", "Roads", "Route",
            "Row",
            "Rue", "Run", "Shoal", "Shoals", "Shore", "Shores", "Skyway", "Spring", "Springs", "Spur", "Spurs",
            "Square", "Squares",
            "Station", "Stravenue", "Stream", "Street", "Streets", "Summit", "Terrace", "Throughway", "Trace", "Track",
            "Trafficway",
            "Trail", "Tunnel", "Turnpike", "Underpass", "Union", "Unions", "Valley", "Valleys", "Via", "Viaduct",
            "View", "Views",
            "Village", "Villages", "Ville", "Vista", "Walk", "Walks", "Wall", "Way", "Ways", "Well", "Wells"
        };
    }
}