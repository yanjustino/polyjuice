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
                switch (19.Randomize())
                {
                    case 0: return $"{AreaCode().ToString()}-{ExchangeCode().ToString()}-#### x#####".Numerify();
                    case 1: return $"{AreaCode().ToString()}-{ExchangeCode().ToString()}-#### x####".Numerify();
                    case 2: return $"{AreaCode().ToString()}-{ExchangeCode().ToString()}-#### x###".Numerify();
                    case 3: return $"{AreaCode().ToString()}-{ExchangeCode().ToString()}-####".Numerify();
                    case 4: return $"{AreaCode().ToString()}-{ExchangeCode().ToString()}-####".Numerify();
                    case 5: return $"{AreaCode().ToString()}.{ExchangeCode().ToString()}.#### x#####".Numerify();
                    case 6: return $"{AreaCode().ToString()}.{ExchangeCode().ToString()}.#### x####".Numerify();
                    case 7: return $"{AreaCode().ToString()}.{ExchangeCode().ToString()}.#### x###".Numerify();
                    case 8: return $"{AreaCode().ToString()}.{ExchangeCode().ToString()}.####".Numerify();
                    case 9: return $"{AreaCode().ToString()}.{ExchangeCode().ToString()}.####".Numerify();
                    case 10: return $"({AreaCode().ToString()}){ExchangeCode().ToString()}-#### x#####".Numerify();
                    case 11: return $"({AreaCode().ToString()}){ExchangeCode().ToString()}-#### x####".Numerify();
                    case 12: return $"({AreaCode().ToString()}){ExchangeCode().ToString()}-#### x###".Numerify();
                    case 13: return $"({AreaCode().ToString()}){ExchangeCode().ToString()}-####".Numerify();
                    case 14: return $"({AreaCode().ToString()}){ExchangeCode().ToString()}-####".Numerify();
                    case 15: return $"1-{AreaCode().ToString()}-{ExchangeCode().ToString()}-#### x#####".Numerify();
                    case 16: return $"1-{AreaCode().ToString()}-{ExchangeCode().ToString()}-#### x####".Numerify();
                    case 17: return $"1-{AreaCode().ToString()}-{ExchangeCode().ToString()}-#### x###".Numerify();
                    case 18: return $"1-{AreaCode().ToString()}-{ExchangeCode().ToString()}-####".Numerify();
                    case 19: return $"1-{AreaCode().ToString()}-{ExchangeCode().ToString()}-####".Numerify();
                    default: return "";
                }
            }
        }

        public static string ShortPhoneNumber =>
            $"{AreaCode().ToString()}-{ExchangeCode().ToString()}-####".Numerify();

        public static string Imei()
        {
            var code = new int[14];
            var result = new StringBuilder();

            for (var i = 0; i < code.Length; i++)
                code[i] = 10.Randomize();

            return result.ToString();
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