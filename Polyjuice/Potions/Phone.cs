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

#if NETSTANDARD
        public static string Number
        {
            get
            {
                switch (19.Randomize())
                {
                    case 0:
                        return $"{AreaCode()}-{ExchangeCode()}-#### x#####".Numerify();
                    case 1:
                        return $"{AreaCode()}-{ExchangeCode()}-#### x####".Numerify();
                    case 2:
                        return $"{AreaCode()}-{ExchangeCode()}-#### x###".Numerify();
                    case 3:
                    case 4:
                        return $"{AreaCode()}-{ExchangeCode()}-####".Numerify();
                    case 5:
                        return $"{AreaCode()}.{ExchangeCode()}.#### x#####".Numerify();
                    case 6:
                        return $"{AreaCode()}.{ExchangeCode()}.#### x####".Numerify();
                    case 7:
                        return $"{AreaCode()}.{ExchangeCode()}.#### x###".Numerify();
                    case 8:
                    case 9:
                        return $"{AreaCode()}.{ExchangeCode()}.####".Numerify();
                    case 10:
                        return $"({AreaCode()}){ExchangeCode()}-#### x#####".Numerify();
                    case 11:
                        return $"({AreaCode()}){ExchangeCode()}-#### x####".Numerify();
                    case 12:
                        return $"({AreaCode()}){ExchangeCode()}-#### x###".Numerify();
                    case 13:
                    case 14:
                        return $"({AreaCode()}){ExchangeCode()}-####".Numerify();
                    case 15:
                        return $"1-{AreaCode()}-{ExchangeCode()}-#### x#####".Numerify();
                    case 16:
                        return $"1-{AreaCode()}-{ExchangeCode()}-#### x####".Numerify();
                    case 17:
                        return $"1-{AreaCode()}-{ExchangeCode()}-#### x###".Numerify();
                    case 18:
                    case 19:
                        return $"1-{AreaCode()}-{ExchangeCode()}-####".Numerify();
                    default:
                        return "";
                }
            }
        }
        
#elif NETSTANDARD2_1
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
#endif        

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