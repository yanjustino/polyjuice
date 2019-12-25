using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Locale
    {
        public static string Language => Data.Languages.Rand();
        public static string LanguageCode => Data.LanguageCodes.Rand();

        private static class Data
        {
            public static string[] Languages { get; } =
            {
                "Afar", "Abkhazian", "Afrikaans", "Amharic", "Arabic", "Assamese", "Aymara", "Azerbaijani", "Bashkir",
                "Byelorussian", "Bulgarian",
                "Bihari", "Bislama", "Bengali", "Tibetan", "Breton", "Catalan", "Corsican", "Czech", "Welsh", "Danish",
                "German", "Bhutani", "Greek",
                "English", "Esperanto", "Spanish", "Estonian", "Basque", "Persian", "Finnish", "Fiji", "Faeroese",
                "French",
                "Frisian", "Irish",
                "Gaelic", "Galician", "Guarani", "Gujarati", "Hausa", "Hindi", "Croatian", "Hungarian", "Armenian",
                "Interlingua", "Interlingue",
                "Inupiak", "Indonesian", "Icelandic", "Italian", "Hebrew", "Japanese", "Yiddish", "Javanese",
                "Georgian",
                "Kazakh", "Greenlandic",
                "Cambodian", "Kannada", "Korean", "Kashmiri", "Kurdish", "Kirghiz", "Latin", "Lingala", "Laothian",
                "Lithuanian", "Latvian",
                "Malagasy", "Maori", "Macedonian", "Malayalam", "Mongolian", "Moldavian", "Marathi", "Malay", "Maltese",
                "Burmese", "Nauru",
                "Nepali", "Dutch", "Norwegian", "Occitan", "Oromo", "Oriya", "Punjabi", "Polish", "Pashto",
                "Portuguese",
                "Quechua", "Rhaeto",
                "Kirundi", "Romanian", "Russian", "Kinyarwanda", "Sanskrit", "Sindhi", "Sangro", "Serbo", "Singhalese",
                "Slovak", "Slovenian",
                "Samoan", "Shona", "Somali", "Albanian", "Serbian", "Siswati", "Sesotho", "Sudanese", "Swedish",
                "Swahili",
                "Tamil", "Tegulu", "Tajik",
                "Thai", "Tigrinya", "Turkmen", "Tagalog", "Setswana", "Tonga", "Turkish", "Tsonga", "Tatar", "Twi",
                "Ukrainian", "Urdu", "Uzbek",
                "Vietnamese", "Volapuk", "Wolof", "Xhosa", "Yoruba", "Chinese", "Zulu"
            };

            public static string[] LanguageCodes { get; } =
            {
                "AA", "AB", "AF", "AM", "AR", "AS", "AY", "AZ", "BA", "BE", "BG", "BH", "BI", "BN", "BO", "BR", "CA",
                "CO",
                "CS", "CY", "DA", "DE", "DZ", "EL",
                "EN", "EO", "ES", "ET", "EU", "FA", "FI", "FJ", "FO", "FR", "FY", "GA", "GD", "GL", "GN", "GU", "HA",
                "HI",
                "HR", "HU", "HY", "IA", "IE", "IK",
                "IN", "IS", "IT", "IW", "JA", "JI", "JW", "KA", "KK", "KL", "KM", "KN", "KO", "KS", "KU", "KY", "LA",
                "LN",
                "LO", "LT", "LV", "MG", "MI", "MK",
                "ML", "MN", "MO", "MR", "MS", "MT", "MY", "NA", "NE", "NL", "NO", "OC", "OM", "OR", "PA", "PL", "PS",
                "PT",
                "QU", "RM", "RN", "RO", "RU", "RW",
                "SA", "SD", "SG", "SH", "SI", "SK", "SL", "SM", "SN", "SO", "SQ", "SR", "SS", "ST", "SU", "SV", "SW",
                "TA",
                "TE", "TG", "TH", "TI", "TK", "TL",
                "TN", "TO", "TR", "TS", "TT", "TW", "UK", "UR", "UZ", "VI", "VO", "WO", "XH", "YO", "ZH", "ZU"
            };
        }
    }
}