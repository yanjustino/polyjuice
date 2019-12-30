using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions.PtBr
{
    public static class Job
    {
        public static string Title => $"{Read("Job", "JobNounsPtBr").Rand()}";
    }
}