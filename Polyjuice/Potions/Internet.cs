using System.Linq;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Internet
    {
        public static string HttpUri => Uri("http");
        public static string DomainName => $"{Name.LastName}.{Data.DomainSuffixes.Rand()}";
        public static string IpV4 => $"{255.Randomize().ToString()}.{255.Randomize().ToString()}.{255.Randomize().ToString()}.{255.Randomize().ToString()}";
        
        public static string Uri(string protocol) => $"{protocol}://{DomainName}";
        public static string Email(string name) => string.Join("@", name, Data.Hosts.Rand());
        public static string DisposableEmail(string name) => string.Join("@", name, Data.DisposableHosts.Rand());

        private static class Data
        {
            public static string Hosts { get; } = "gmail.com yahoo.com hotmail.com";
            public static string DisposableHosts { get; } = "mailinator.com suremail.info spamherelots.com binkmail.com safetymail.info";
            public static string DomainSuffixes { get; } = "co.uk com us ca biz info name com.br";
        }
    }
}