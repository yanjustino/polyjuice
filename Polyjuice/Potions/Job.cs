using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The work that you do in order to get money
    /// </summary>
    public static class Job
    {
        public static string Title => $"{JobData.Prefixes.Rand()} {JobData.Adjectives.Rand()} {JobData.Nouns.Rand()}";
    }
}