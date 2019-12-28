using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// A large meeting, often lasting a few days, where people talk about a subject
    /// </summary>
    public static class Conference
    {
        public static string Title => ConferenceData.ConferenceList.Rand();
    }
}