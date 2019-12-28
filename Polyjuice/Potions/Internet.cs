using Polyjuice.Extension;
using Polyjuice.Potions.Data;

namespace Polyjuice.Potions
{
    /// <summary>
    /// A system that connects computers around the world so you can share information with other people
    /// </summary>
    public static class Internet
    {
        public static string HttpUri => Uri("http");
        public static string DomainName => $"{Name.LastName}.{InternetData.DomainSuffixes.Rand()}";
        public static string IpV4 => $"{255.Randomize().ToString()}.{255.Randomize().ToString()}.{255.Randomize().ToString()}.{255.Randomize().ToString()}";
        
        
        public static string Uri(string protocol) => $"{protocol}://{DomainName}";
        public static string Email(string name) => string.Join("@", name, InternetData.Hosts.Rand());
        public static string DisposableEmail(string name) => string.Join("@", name, InternetData.DisposableHosts.Rand());
        
    }
}