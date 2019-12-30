using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions.PtBr
{
    public static class Address
    {
        // Private Data
        public static string StreetPrefix => "Rua Avenida Travessa Alameda";
        
        
        // Properties
        public static string State => Read("Address", "StatesPtBr").Rand();
        public static string StateAbbr => Read("Address", "StatesAbbrPtBr").Rand();
        public static string City => Read("Address", "CitiesPtBr").Rand();
        public static string ZipCode => "#####-###".Numerify();
        public static string Location => $"{StreetName}, {"###".Numerify()} ";
        public static string BuildingNumber => "### #####".Rand().Numerify();

        // Methods
        public static string StreetName
        {
            get
            {
                switch (2.Randomize())
                {
                    case 0:
                        return $"{StreetPrefix.Rand()} {Name.FullName}";
                    case 1:
                        return $"{StreetPrefix.Rand()} {Name.FirstName} {Name.LastName} {Name.LastName}";
                    default:
                        return string.Empty;
                }
            }
        }
    }
}