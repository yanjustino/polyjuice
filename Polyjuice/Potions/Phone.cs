using System;
using System.Text;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Phone
    {
        /// <summary>
        /// The North American Numbering Plan (NANP) does not permit the digits 0
        /// and 1 as the leading digit of the exchange code.
        /// https://en.wikipedia.org/wiki/North_American_Numbering_Plan#Numbering_system
        /// </summary>
        public static string Number
        {
            get
            {
                return 19.Randomize() switch
                {
                    0 => $"{AreaCode()}-{ExchangeCode()}-#### x#####".Numerify(),
                    1 => $"{AreaCode()}-{ExchangeCode()}-#### x####".Numerify(),
                    2 => $"{AreaCode()}-{ExchangeCode()}-#### x###".Numerify(),
                    3 => $"{AreaCode()}-{ExchangeCode()}-####".Numerify(),
                    4 => $"{AreaCode()}-{ExchangeCode()}-####".Numerify(),
                    5 => $"{AreaCode()}.{ExchangeCode()}.#### x#####".Numerify(),
                    6 => $"{AreaCode()}.{ExchangeCode()}.#### x####".Numerify(),
                    7 => $"{AreaCode()}.{ExchangeCode()}.#### x###".Numerify(),
                    8 => $"{AreaCode()}.{ExchangeCode()}.####".Numerify(),
                    9 => $"{AreaCode()}.{ExchangeCode()}.####".Numerify(),
                    10 => $"({AreaCode()}){ExchangeCode()}-#### x#####".Numerify(),
                    11 => $"({AreaCode()}){ExchangeCode()}-#### x####".Numerify(),
                    12 => $"({AreaCode()}){ExchangeCode()}-#### x###".Numerify(),
                    13 => $"({AreaCode()}){ExchangeCode()}-####".Numerify(),
                    14 => $"({AreaCode()}){ExchangeCode()}-####".Numerify(),
                    15 => $"1-{AreaCode()}-{ExchangeCode()}-#### x#####".Numerify(),
                    16 => $"1-{AreaCode()}-{ExchangeCode()}-#### x####".Numerify(),
                    17 => $"1-{AreaCode()}-{ExchangeCode()}-#### x###".Numerify(),
                    18 => $"1-{AreaCode()}-{ExchangeCode()}-####".Numerify(),
                    19 => $"1-{AreaCode()}-{ExchangeCode()}-####".Numerify(),
                    _ => ""
                };
            }
        }

        /// <summary>
        /// The North American Numbering Plan (NANP) does not permit the digits 0
        /// and 1 as the leading digit of the exchange code.
        /// https://en.wikipedia.org/wiki/North_American_Numbering_Plan#Numbering_system
        /// </summary>
        public static string ShortPhoneNumber =>
            $"{AreaCode()}-{ExchangeCode()}-####".Numerify();

        public static string Imei()
        {
            var code = new int[14];
            var IMEI = new StringBuilder();
            for (var i = 0; i < code.Length; i++)
            {
                code[i] = 10.Randomize();
            }
            return IMEI.ToString();
        }        
        
        private static int AreaCode()
        {
            while (true)
            {
                var randAreaCode = 999.Randomize(201);
                if (randAreaCode % 100 != 11)
                    return randAreaCode;
            }
        }

        private static int ExchangeCode() => AreaCode();
    }
}