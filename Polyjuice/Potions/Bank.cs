using System.Collections.Generic;
using System.Linq;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    /// <summary>
    /// A place where you can keep or borrow money
    /// </summary>
    public static class Bank
    {
        public static string CardNumber => "#### #### #### ####".Numerify();
        public static string CardExpiryDate => $"{DateAndTime.Month:00}/{DateAndTime.NextFiftyYears.ToString()}";
        public static string CardType => Data.CardTypes.Rand();

        public static string Iban(string countryCode = null)
        {
            return (countryCode == null)
                ? Data.Countries.Values.ToArray().Rand().Numerify().Letterify()
                : Data.Countries[countryCode].Numerify().Letterify();
        }

        private static class Data
        {
            public static string CardTypes =>
                "visa mastercar american_express discover diners_club jcb switch solo dankort maestro forbrugsforeningen laser"
                    .Rand();

            public static Dictionary<string, string> Countries { get; } = new Dictionary<string, string>
            {
                ["AA"] = "AL##########################", //# Albania
                ["AD"] = "AD######################", //# Andorra
                ["AT"] = "AT##################", //# Austria
                ["AZ"] = "AZ##????####################", //# Azerbaijan
                ["BH"] = "BH##????##############", //# Bahrain
                ["BY"] = "BY##????####################", //# Belarus
                ["BE"] = "BE##############", //# Belgium
                ["BA"] = "BA##################", //# Bosnia and Herzegovina
                ["BR"] = "BR#########################P#", //# Brazil
                ["BG"] = "BG##????##############", //# Bulgaria
                ["CR"] = "CR####################", //# Costa Rica
                ["HR"] = "HR###################", //# Croatia
                ["CY"] = "CY##########################", //# Cyprus
                ["CZ"] = "CZ######################", //# Czech Republic
                ["DK"] = "DK################", //# Denmark
                ["DO"] = "DO##????####################", //# Dominican Republic
                ["SV"] = "SV##????####################", //# El Salvador
                ["EE"] = "EE##################", //# Estonia
                ["FO"] = "FO################", //# Faroe Islands
                ["FI"] = "FI################", //# Finland
                ["FR"] = "FR#########################", //# France
                ["GE"] = "GE##??################", //# Georgia
                ["DE"] = "DE####################", //# Germany
                ["GI"] = "GI##????###############", //# Gibraltar
                ["GR"] = "GR#########################", //# Greece
                ["GL"] = "GL################", //# Greenland
                ["GT"] = "GT##AGRO####################", //# Guatemala
                ["VA"] = "VA####################", //# Holy See
                ["HU"] = "HU##########################", //# Hungary
                ["IS"] = "IS########################", //# Iceland
                ["IQ"] = "IQ##????###############", //# Iraq
                ["IE"] = "IE##????##############", //# Ireland
                ["IL"] = "IL#####################", //# Israel
                ["IT"] = "IT##X######################", //# Italy
                ["JO"] = "JO##????######################", //# Jordan
                ["KZ"] = "KZ##################", //# Kazakhstan
                ["XK"] = "XK##################", //# Kosovo
                ["KW"] = "KW##????######################", //# Kuwait
                ["LV"] = "LV##????#############", //# Latvia
                ["LB"] = "LB##########################", //# Lebanon
                ["LI"] = "LI###################", //# Liechtenstein
                ["LT"] = "LT##################", //# Lithuania
                ["LU"] = "LU##################", //# Luxembourg
                ["MT"] = "MT##MALT#######################", //# Malta
                ["MR"] = "MR#########################", //# Mauritania
                ["MU"] = "MU##????###################MUR", //# Mauritius
                ["MD"] = "MD##??##################", //# Moldova
                ["MC"] = "MC#########################", //# Monaco
                ["ME"] = "ME####################", //# Montenegro
                ["NL"] = "NL##????##########", //# Netherlands
                ["MK"] = "MK#################", //# North Macedonia
                ["NO"] = "NO#############", //# Norway
                ["PK"] = "PK##????################", //# Pakistan
                ["PS"] = "PS##PALS#####################", //# Palestine
                ["PL"] = "PL##########################", //# Poland
                ["PT"] = "PT#######################", //# Portugal
                ["QA"] = "QA##????#####################", //# Qatar
                ["RO"] = "RO##????################", //# Romania
                ["LC"] = "LC##????########################", //# Saint Lucia
                ["SM"] = "SM##P######################", //# San Marino
                ["ST"] = "ST#######################", //# Sao Tome and Principe
                ["SA"] = "SA######################", //# Saudi Arabia
                ["RS"] = "RS####################", //# Serbia
                ["SC"] = "SC##????####################USD", //# Seychelles
                ["SK"] = "SK######################", //# Slovak Republic
                ["SI"] = "SI#################", //# Slovenia
                ["ES"] = "ES######################", //# Spain
                ["SE"] = "SE######################", //# Sweden
                ["CH"] = "CH###################", //# Switzerland
                ["TL"] = "TL#####################", //# Timor-Leste
                ["TN"] = "TN######################", //# Tunisia
                ["TR"] = "TR########################", //# Turkey
                ["UA"] = "UA###########################", //# Ukraine
                ["AE"] = "AE#####################", //# United Arab Emirates
                ["GB"] = "GB##????##############", //# United Kingdom
                ["VG"] = "VG##????################" //# Virgin Islands, British
            };
        }
    }
}