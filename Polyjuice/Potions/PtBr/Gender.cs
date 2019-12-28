using Polyjuice.Extension;

namespace Polyjuice.Potions.PtBr
{
    public static class Gender
    {
        private static string Genders =>
            "Feminino Masculino Não-binário Agênero Andrógino Assexual Bissexual Pansexual Transgênero Transexual Lésbica homossexual";
        
        private static string BinaryGenders =>
            "Feminino Masculino";    
        
        
        public static string Random => Genders.Rand();
        public static string Binary => BinaryGenders.Rand();
    }
}