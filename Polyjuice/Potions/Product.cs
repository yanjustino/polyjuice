using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// something that is made to be sold, usually something that is produced by an industrial process or,
    /// less commonly, something that is grown or obtained through farming:
    /// </summary>
    public static class Product
    {
        public static string Name => $"{ProductData.Adjectives.Rand()} {ProductData.Nouns.Rand()} {ProductData.B1.Rand()}";
    }
}