using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    /// <summary>
    /// something that is made to be sold, usually something that is produced by an industrial process or,
    /// less commonly, something that is grown or obtained through farming:
    /// </summary>
    public static class Product
    {
        public static string Name => 
            $"{Read("Product", "ProductAdjectives").Rand()} " +
            $"{Read("Product", "ProductNouns").Rand()} " +
            $"{Read("Product", "ProductB1").Rand()}";
    }
}