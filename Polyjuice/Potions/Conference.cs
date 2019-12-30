using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;


namespace Polyjuice.Potions
{
    /// <summary>
    /// A large meeting, often lasting a few days, where people talk about a subject
    /// </summary>
    public static class Conference
    {
        public static string Title => Read("Conference",  "ConferenceList").Rand();
    }
}