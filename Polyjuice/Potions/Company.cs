using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Company
    {
        private static string[] Suffixes { get; } =
        {
            "Inc", "Inc and Sons", "LLC", "Group"
        };

        public static string Name
        {
            get
            {
                return 3.Randomize() switch
                {
                    0 => $"{Polyjuice.Potions.Name.LastName} {Suffixes.Rand()}",
                    1 => $"{Polyjuice.Potions.Name.LastName}-{Polyjuice.Potions.Name.LastName}",
                    2 => $"{Polyjuice.Potions.Name.LastName}, {Polyjuice.Potions.Name.LastName} and {Polyjuice.Potions.Name.LastName}",
                    _ => string.Empty
                };
            }
        }        
    }
}