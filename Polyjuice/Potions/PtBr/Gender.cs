using Polyjuice.Extension;

namespace Polyjuice.Potions.PtBr
{
    public static class Gender
    {
        public static string Random => Data.Genders.Rand();
        public static string Binary => Data.BinaryGenders.Rand();
        
        private static class Data
        {
            public static string Genders =>
                "Feminino Masculino Não-binário Agênero Andrógino Assexual Bissexual Pansexual Transgênero Transexual Lésbica homossexual";
        
            public static string BinaryGenders =>
                "Feminino Masculino";    
        } 
    }
}