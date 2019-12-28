using System.Linq;
using Polyjuice.Extension;
using static System.Decimal;

namespace Polyjuice.Potions.PtBr
{
    public static class Phone
    {
        private static string CountryPrefix => "+55";
        private static string PhoneNumber => "####### ###-####";
        private static int[] AreaCode { get; } = Enumerable.Range(10, 99).ToArray();
        private static string HomeWorkPhonePrefix { get; } = "2 3 4 5";
        private static string MobilePhonePrefix { get; } = "96 97 98 99";
        
        
        public static string Number => 1.Randomize() == Zero ? HomeWorkPhoneNumber : MobilePhoneNumber;
        public static string HomeWorkPhoneNumber => NewNumber(HomeWorkPhonePrefix.Rand());
        public static string MobilePhoneNumber => NewNumber(MobilePhonePrefix.Rand());
        public static string InternationalMobilePhoneNumber => NewNumber(MobilePhonePrefix.Rand(), CountryPrefix);
        public static string InternationalHomeWorkPhoneNumber => NewNumber(MobilePhonePrefix.Rand(), CountryPrefix);

        
        private static string NewNumber(string prefixes, string countryPrefix = "")
        {
            var space = 1.Randomize() == Zero ? " " : "";

            var p = string.Join(
                string.Empty,
                countryPrefix,
                space,
                AreaCode.Rand().ToString(),
                space,
                prefixes,
                PhoneNumber.Rand()
            );

            return p.Numerify();
        }
    }
}