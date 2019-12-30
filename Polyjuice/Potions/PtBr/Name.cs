using System.Linq;
using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions.PtBr
{
    public static class Name
    {
        // Private Data
        private static string FemalePrefixes => "Sr. Sra. Srta.";
        private static string MalePrefixes => "Sr";
        private static string[] FirstNames => Read("Name", "FirstNamesFemalePtBr").Union(Read("Name", "FirstNamesMalePtBr")).ToArray();
        private static string Prefixes => $"{FemalePrefixes} {MalePrefixes}";
        

        // Properties
        public static string LastName => Read("Name", "LastNamesPtBr").Rand();
        public static string FirstNameFemale => Read("Name", "FirstNamesFemalePtBr").Rand();
        public static string FirstNameMale => Read("Name", "FirstNamesMalePtBr").Rand();
        public static string FemalePrefix => FemalePrefixes.Rand();
        public static string MalePrefix => MalePrefixes.Rand();
        public static string FirstName => FirstNames.Rand();
        public static string Prefix => Prefixes.Rand();
        public static string FullName => $"{FirstName} {LastName}";
        public static string FemaleNameWithPrefix => $"{FemalePrefix} {FirstNameFemale} {LastName}";
        public static string MaleNameWithPrefix => $"{MalePrefix} {FirstNameMale} {LastName}";
        public static string NameWithPrefix => new string[] {FemaleNameWithPrefix, MaleNameWithPrefix}.Rand();

    }
}