using System;
using System.Globalization;
using Polyjuice.Extension;

namespace Polyjuice.Potions.PtBr
{
    public static class Price
    {
        public static decimal Value => Convert.ToDecimal("#####.##m".Numerify());
        public static string Currency  => "R$";
        public static string ValueWithCurrency  => $"R$ {Value.ToString(CultureInfo.GetCultureInfo("pt-BR"))}";
    }
}