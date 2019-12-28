using System.Linq;
using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions.PtBr
{
    public static class Name
    {
        public static string[] FirstNames => NameDataPtBr.FirstNamesFemale.Union(NameDataPtBr.FirstNamesMale).ToArray();
        public static string Prefixes => $"{NameDataPtBr.FemalePrefixes} {NameDataPtBr.MalePrefixes}";
        public static string LastName => NameDataPtBr.LastNames.Rand();
        public static string FirstNameFemale => NameDataPtBr.FirstNamesFemale.Rand();
        public static string FirstNameMale => NameDataPtBr.FirstNamesMale.Rand();
        public static string FemalePrefix => NameDataPtBr.FemalePrefixes.Rand();
        public static string MalePrefix => NameDataPtBr.MalePrefixes.Rand();
        public static string FirstName => FirstNames.Rand();
        public static string Prefix => Prefixes.Rand();
        public static string FullName => $"{FirstName} {LastName}";
        public static string FemaleNameWithPrefix => $"{FemalePrefix} {FirstNameFemale} {LastName}";
        public static string MaleNameWithPrefix => $"{MalePrefix} {FirstNameMale} {LastName}";
        public static string NameWithPrefix => new string[] {FemaleNameWithPrefix, MaleNameWithPrefix}.Rand();

    }
}