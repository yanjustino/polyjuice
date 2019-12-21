using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class Job
    {
        public static string Title => $"{Prefixies.Rand()} {Adjectives.Rand()} {Nouns.Rand()}";

        private static string[] Prefixies { get; } =
        {
            "Lead",
            "Senior",
            "Direct",
            "Corporate",
            "Dynamic",
            "Future",
            "Product",
            "National",
            "Regional",
            "District",
            "Central",
            "Global",
            "Customer",
            "Investor",
            "Dynamic",
            "International",
            "Legacy",
            "Forward",
            "Internal",
            "Human",
            "Chief",
            "Principal",
        };
        
        private static string[] Nouns { get; } =
        {
            "Supervisor",
            "Associate",
            "Executive",
            "Liason",
            "Officer",
            "Manager",
            "Engineer",
            "Specialist",
            "Director",
            "Coordinator",
            "Administrator",
            "Architect",
            "Analyst",
            "Designer",
            "Planner",
            "Orchestrator",
            "Technician",
            "Developer",
            "Producer",
            "Consultant",
            "Assistant",
            "Facilitator",
            "Agent",
            "Representative",
            "Strategist",
        };

        private static string[] Adjectives { get; } =
        {
            "Solutions",
            "Program",
            "Brand",
            "Security",
            "Research",
            "Marketing",
            "Directives",
            "Implementation",
            "Integration",
            "Functionality",
            "Response",
            "Paradigm",
            "Tactics",
            "Identity",
            "Markets",
            "Group",
            "Division",
            "Applications",
            "Optimization",
            "Operations",
            "Infrastructure",
            "Intranet",
            "Communications",
            "Web",
            "Branding",
            "Quality",
            "Assurance",
            "Mobility",
            "Accounts",
            "Data",
            "Creative",
            "Configuration",
            "Accountability",
            "Interactions",
            "Factors",
            "Usability",
            "Metrics",
        };
    }
}