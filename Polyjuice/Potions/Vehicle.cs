using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    /// <summary>
    /// A machine, usually with wheels and an engine, used for transporting people or goods on land,
    /// especially on roads:
    /// </summary>
    public static class Vehicle
    {
        public static string Make => Data.Makes.Rand();
        public static string Model => Data.Models.Rand();
        public static string Trim => Data.Trims.Rand();

        private static class Data
        {
            public static string[] Makes { get; } =
            {
                "Acura", "Alfa Romeo", "AM General", "AMC", "Aston Martin", "Audi", "Autocar", "Avanti", "Bentley",
                "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Country Coach", "Daewoo", "Daihatsu", "Dodge", "Eagle", "Ferrari",
                "Fiat", "Ford", "Freightliner", "Geo", "GMC", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jaguar", "Jeep",
                "Kia", "Lada", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Lodal", "Lotus", "Maserati", "Maybach", "Mazda", "Mercedes-Benz",
                "Mercury", "Merkur", "Mini", "Mitsubishi", "Morgan", "Nissan", "Oldsmobile", "Oshkosh", "Peugeot", "Plymouth", "Polaris", "Pontiac",
                "Porsche", "Ram", "Renault", "Rolls-Royce", "Saab", "Saleen", "Saturn", "Scion", "Smart", "Sterling", "Subaru", "Suzuki", "Tesla",
                "Toyota", "Volkswagen", "Volvo"
            };

            public static string[] Models { get; } =
            {
                "4Runner", "Accent", "Accord", "Alero", "Allante", "Altima", "Astro", "Avenger", "Aveo", "Aztek",
                "Beetle", "Bravada", "Bronco", "Caliber", "Camaro", "Camry", "Caprice", "Caravan", "Cavalier", "Charger", "Cherokee", "Civic", "Cobalt", "Colorado", "Concorde",
                "Contour", "Corolla", "Corolla Wagon", "Corvette", "CR-V", "CR-Z", "Cutlass", "Dakota", "Durango",
                "Echo", "Econoline", "Elantra", "Element", "Envoy", "Equinox", "Escalade", "Escort", "Expedition", "Fiero", "Focus", "Freestyle",
                "Frontier", "Fusion", "Ghost", "Golf", "Grand Am", "Grand Caravan", "Grand Cherokee", "Grand Marquis", "Grand Marquis Wagon",
                "Grand Prix", "HHR", "Highlander", "Hummer", "Impala", "Impreza", "Integra", "Intrepid", "Intrigue", "Jetta", "Jimmy", "Lancer", "LaSabre",
                "Magnum", "Malibu", "Mustang", "Neon", "Odyssey", "Optima", "Pacifica", "Passat", "Pathfinder", "Prius", "Probe", "Protege",
                "PT Cruiser", "Quest", "Rabbit", "RAV4", "Rio", "S10", "Sable", "Santa Fe", "Sierra", "Silverado", "Sonata", "Sprinter",
                "Tahoe", "Taurus", "Tercel", "Town & Country", "Trailblazer", "Trans Am", "Uplander", "Villager", "Viper", "Voyager", "Windstar",
                "Yaris", "Yukon", "Zephyr"
            };

            public static string[] Trims { get; } =
            {
                "DX", "ES", "EX", "EX-L", "GL", "GS", "LS", "LT", "RS", "SE", "SI", "SLT", "XLT"
            };
        }
    }
}