using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions.PtBr
{
    public static class Address
    {
        public static string State => AddressDataPtBr.States.Rand();
        public static string StateAbbr => AddressDataPtBr.StatesAbbr.Rand();
        public static string City => AddressDataPtBr.Cities.Rand();
        public static string ZipCode => "#####-###".Numerify();
        public static string Location => $"{StreetName}, {"###".Numerify()} ";
        public static string BuildingNumber => "### #####".Rand().Numerify();

        public static string StreetName
        {
            get
            {
                switch (2.Randomize())
                {
                    case 0:
                        return $"{AddressDataPtBr.StreetPrefix.Rand()} {Name.FullName}";
                    case 1:
                        return $"{AddressDataPtBr.StreetPrefix.Rand()} {Name.FirstName} {Name.LastName} {Name.LastName}";
                    default:
                        return string.Empty;
                }
            }
        }
    }
}