using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Address
    {
        public static string State => Data.States.Rand();
        public static string StateAbbr => Data.StatesAbbr.Rand();
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
                        return $"{Name.LastName} {Data.StreetSufix.Rand()}";
                    case 1:
                        return $"{Name.FirstName} {Data.StreetSufix.Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }

        public static string City
        {
            get
            {
                var prefix = Data.CompassDirections.Union(Data.CityPrefixes).ToArray();
                
                switch (4.Randomize())
                {
                    case 0:
                        return $"{prefix.Rand()} {Name.FirstName}";
                    case 1:
                        return $"{prefix.Rand()} {Name.FirstName} {Data.CitySufix.Rand()}";
                    case 2:
                        return $"{Name.FirstName} {Data.CitySufix.Rand()}";
                    case 3:
                        return $"{Name.LastName} {Data.CitySufix.Rand()}";
                    default:
                        return string.Empty;
                }
            }
        }

        private static class Data
        {
            public static string[] StatesAbbr { get; } =
            {
                "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI",
                "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV",
                "NH",
                "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA",
                "WA",
                "WV", "WI", "WY"
            };

            public static string[] States { get; } =
            {
                "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
                "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas",
                "Kentucky",
                "Louisiana",
                "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana",
                "Nebraska", "Nevada",
                "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
                "Oklahoma", "Oregon",
                "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah",
                "Vermont",
                "Virginia",
                "Washington", "West Virginia", "Wisconsin", "Wyoming"
            };

            public static string[] CompassDirections { get; } =
            {
                "North", "East", "West", "South"
            };

            public static string[] CityPrefixes { get; } =
            {
                "New", "Lake", "Port"
            };

            public static string[] CitySufix { get; } =
            {
                "town", "ton", "land", "ville", "berg", "burgh", "borough", "bury", "view", "port",
                "mouth", "stad", "furt", "chester", "mouth", "fort", "haven", "side", "shire"
            };

            public static string[] StreetSufix { get; } =
            {
                "Alley", "Avenue", "Branch", "Bridge", "Brook", "Brooks", "Burg", "Burgs", "Bypass", "Camp",
                "Canyon", "Cape", "Causeway", "Center", "Centers", "Circle", "Circles", "Cliff", "Cliffs", "Club",
                "Common",
                "Corner",
                "Corners", "Course", "Court", "Courts", "Cove", "Coves", "Creek", "Crescent", "Crest", "Crossing",
                "Crossroad", "Curve",
                "Dale", "Dam", "Divide", "Drive", "Drives", "Estate", "Estates", "Expressway", "Extension",
                "Extensions",
                "Fall", "Falls",
                "Ferry", "Field", "Fields", "Flat", "Flats", "Ford", "Fords", "Forest", "Forge", "Forges", "Fork",
                "Forks",
                "Fort",
                "Freeway", "Garden", "Gardens", "Gateway", "Glen", "Glens", "Green", "Greens", "Grove", "Groves",
                "Harbor",
                "Harbors",
                "Haven", "Heights", "Highway", "Hill", "Hills", "Hollow", "Inlet", "Island", "Islands", "Isle",
                "Junction",
                "Junctions",
                "Key", "Keys", "Knoll", "Knolls", "Lake", "Lakes", "Land", "Landing", "Lane", "Light", "Lights", "Loaf",
                "Lock", "Locks",
                "Lodge", "Loop", "Mall", "Manor", "Manors", "Meadow", "Meadows", "Mews", "Mill", "Mills", "Mission",
                "Motorway", "Mount",
                "Mountain", "Mountains", "Neck", "Orchard", "Oval", "Overpass", "Park", "Parks", "Parkway", "Parkways",
                "Pass", "Passage",
                "Path", "Pike", "Pine", "Pines", "Place", "Plain", "Plains", "Plaza", "Point", "Points", "Port",
                "Ports",
                "Prairie",
                "Radial", "Ramp", "Ranch", "Rapid", "Rapids", "Rest", "Ridge", "Ridges", "River", "Road", "Roads",
                "Route",
                "Row",
                "Rue", "Run", "Shoal", "Shoals", "Shore", "Shores", "Skyway", "Spring", "Springs", "Spur", "Spurs",
                "Square", "Squares",
                "Station", "Stravenue", "Stream", "Street", "Streets", "Summit", "Terrace", "Throughway", "Trace",
                "Track",
                "Trafficway",
                "Trail", "Tunnel", "Turnpike", "Underpass", "Union", "Unions", "Valley", "Valleys", "Via", "Viaduct",
                "View", "Views",
                "Village", "Villages", "Ville", "Vista", "Walk", "Walks", "Wall", "Way", "Ways", "Well", "Wells"
            };
        }
    }
}