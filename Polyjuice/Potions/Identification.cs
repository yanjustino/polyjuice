using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    /// <summary>
    /// An official document that shows or proves who you are
    /// </summary>
    public static class Identification
    {
        private static string[] Ethnicities { get; } =
        {
            "African American", "Asian/Pacific Islander", "Caucasian", "Hispanic", "Native American",
            "Multiracial", "Other", "Prefer not to respond"
        };        
        
        
        public static string DriversLicense => "###-###-##-###-#".Numerify();
        public static string Ssn => "###-##-####".Numerify();
        public static string Ethnicity => Ethnicities.Rand();
    }
}