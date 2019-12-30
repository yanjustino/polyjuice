using Polyjuice.Extension;
using  static  Polyjuice.Potions.Data.DataReader;

namespace Polyjuice.Potions
{
    /// <summary>
    /// A system that connects computers around the world so you can share information with other people
    /// </summary>
    public static class Internet
    {
        // Properties
        public static string HttpUri => Uri("http");
        public static string DomainName => $"{Name.LastName}.{Read("Internet", "DomainSuffixes").Rand()}";
        public static string IpV4 => $"{255.Randomize().ToString()}.{255.Randomize().ToString()}.{255.Randomize().ToString()}.{255.Randomize().ToString()}";
        
        
        // Methods
        public static string Uri(string protocol) => $"{protocol}://{DomainName}";
        public static string UriWithCountry(string protocol) => $"{protocol}://{DomainName}.{Country.Code.ToLower()}";
        public static string Email(string name) => string.Join("@", name, Read("Internet", "Hosts").Rand());
        public static string DisposableEmail(string name) => string.Join("@", name, Read("Internet", "DisposableHosts").Rand());
        
    }
}