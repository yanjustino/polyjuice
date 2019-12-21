using System.Linq;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Internet
    {
        public static string HttpUri => Uri("http");
        public static string DomainName => $"{Company.Name.Split(' ').First().ToLower()}.{DomainSuffixes.Rand()}";
        public static string IpV4 => $"{255.Randomize()}.{255.Randomize()}.{255.Randomize()}.{255.Randomize()}";
        
        public static string Uri(string protocol) => $"{protocol}://{DomainName}";
        public static string Email(string name) => string.Join("@", name, Hosts.Rand());
        public static string DisposableEmail(string name) => string.Join("@", name, DisposableHosts.Rand());

        private static string Hosts { get; } = "gmail.com yahoo.com hotmail.com";
        private static string DisposableHosts { get; } = "mailinator.com suremail.info spamherelots.com binkmail.com safetymail.info";
        private static string DomainSuffixes { get; } = "co.uk com us ca biz info name";
    }
}