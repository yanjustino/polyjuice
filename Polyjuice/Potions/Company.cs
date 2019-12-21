using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Company
    {
        private static string[] Suffixes { get; } =
        {
            "Inc", "Inc and Sons", "LLC", "Group"
        };

#if NETSTANDARD
        public static string Name
        {
            get
            {
                switch (3.Randomize())
                {
                    case 0:
                        return $"{Polyjuice.Potions.Name.LastName} {Suffixes.Rand()}";
                    case 1:
                        return $"{Polyjuice.Potions.Name.LastName}-{Polyjuice.Potions.Name.LastName}";
                    case 2:
                        return
                            $"{Polyjuice.Potions.Name.LastName}, {Polyjuice.Potions.Name.LastName} and {Polyjuice.Potions.Name.LastName}";
                    default:
                        return string.Empty;
                }
            }
        } 
        
#elif NETSTANDARD2_1
        
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
        
#endif         
    }
}