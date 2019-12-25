using System.Linq;
using Polyjuice.Extension;
using static System.Decimal;

namespace Polyjuice.Potions.PtBr
{
    public static class Phone
    {
        public static string Number =>
            1.Randomize() == Zero ? HomeWorkPhoneNumber : MobilePhoneNumber;
        
        public static string HomeWorkPhoneNumber =>
            Data.Number(Data.HomeWorkPhonePrefix.Rand());
        
        public static string MobilePhoneNumber =>
            Data.Number(Data.MobilePhonePrefix.Rand());

        public static string InternationalMobilePhoneNumber =>
            Data.Number(Data.MobilePhonePrefix.Rand(), Data.CountryPrefix);
        
        public static string InternationalHomeWorkPhoneNumber =>
            Data.Number(Data.MobilePhonePrefix.Rand(), Data.CountryPrefix);

        
        private static class Data
        {
            public static string CountryPrefix => "+55";
            public static string PhoneNumber => "####### ###-####";
            
            public static int[] AreaCode { get; } = Enumerable.Range(10, 99).ToArray();
            public static string HomeWorkPhonePrefix { get; } = "2 3 4 5";
            public static string MobilePhonePrefix { get; } = "96 97 98 99";

            public static string Number(string prefixes, string countryPrefix = "")
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
}