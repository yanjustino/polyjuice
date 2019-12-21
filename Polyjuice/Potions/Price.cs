using System;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Price
    {
        public static decimal Value => Convert.ToDecimal("#####.##m".Numerify());
    }
}