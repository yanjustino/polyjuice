using Polyjuice.Extension;
using GlobalCompany = Polyjuice.Potions.Company;

namespace Polyjuice.Potions
{
    /// <summary>
    /// An employee that works for an organization
    /// </summary>
    public static class Employee
    {
        public static string Username => Name.FirstName;
        public static string FullName => $"{Username} {Name.LastName}";
        public static string Enrollment => "########".Numerify();
        public static string Company => GlobalCompany.CompanyName;
        public static string Role => Job.SummaryTitle;
    }
}