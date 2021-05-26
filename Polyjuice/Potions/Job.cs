using Polyjuice.Extension;
using static Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    /// <summary>
    /// The work that you do in order to get money
    /// </summary>
    public static class Job
    {
        public static string Title =>
            $"{Read("Job", "JobPrefixes").Rand()} {Read("Job", "JobAdjectives").Rand()} {Read("Job", "JobNouns").Rand()}";

        public static string SummaryTitle => $"{Read("Job", "JobNouns").Rand()}";
    }
}