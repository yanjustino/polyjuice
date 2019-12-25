using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Identification
    {
        public static string DriversLicense => "###-###-##-###-#".Numerify();
        public static string Ssn => "###-##-####".Numerify();
        public static string Ethnicity => Data.Ethnicities.Rand();

        private static class Data
        {
            public static string[] Ethnicities { get; } =
            {
                "African American", "Asian/Pacific Islander", "Caucasian", "Hispanic", "Native American",
                "Multiracial", "Other", "Prefer not to respond"
            };
        }
    }
}