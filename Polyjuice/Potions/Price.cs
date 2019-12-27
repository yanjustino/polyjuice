using System;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The amount of money for which something is sold:
    /// </summary>
    public static class Price
    {
        public static decimal Value => Convert.ToDecimal("#####.##".Numerify());
    }
}