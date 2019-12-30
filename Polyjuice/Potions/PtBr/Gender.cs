using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions.PtBr
{
    public static class Gender
    {
        // Private Data
        private static string BinaryGenders => "Feminino Masculino";    
        
        
        // Properties
        public static string Random =>Read("Gender", "GendersPtBr").Rand();
        public static string Binary => BinaryGenders.Rand();
    }
}