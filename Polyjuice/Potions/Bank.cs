using System.Collections.Generic;
using System.Linq;
using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// A place where you can keep or borrow money
    /// </summary>
    public static class Bank
    {
        public static string CardNumber => "#### #### #### ####".Numerify();
        public static string CardExpiryDate => $"{DateAndTime.Month:00}/{DateAndTime.NextFiftyYears.ToString()}";
        public static string CardType => BankData.CardTypes.Rand();

        
        public static string Iban(string countryCode = null)
        {
            return (countryCode == null)
                ? BankData.Countries.Values.ToArray().Rand().Numerify().Letterify()
                : BankData.Countries[countryCode].Numerify().Letterify();
        }
    }
}