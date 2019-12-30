using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions
{
    /// <summary>
    /// The state of being...
    /// </summary>
    public static class Gender
    {
        private static string BinaryGenders => "male female";
        private static string Genders => Read("Gender", "Genders").Rand();
        
        
        public static string Random => Genders.Rand();
        public static string Binary => BinaryGenders.Rand();
    }
}