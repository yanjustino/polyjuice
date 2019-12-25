using Polyjuice.Extension;

namespace Polyjuice.Potions.PtBr
{
    public static class Job
    {
        public static string Title => $"{Data.Nouns.Rand()}";
        
        private static class Data
        {
            public static string[] Nouns { get; } =
            {
                "Arquiteto",
                "Astro do Rock",
                "Atendente",
                "Atleta",
                "Bibliotecário",
                "Biomédico",
                "Biólogo",
                "Bombeiro",
                "Caixa",
                "Chef de Cozinha",
                "Cientista",
                "Consultor",
                "DJ",
                "Dentista",
                "Deputado",
                "Desenvolvedor de Software",
                "Designer",
                "Diarista",
                "Diretor de Cinema",
                "Eletricista",
                "Encanador",
                "Enfermeiro",
                "Engenheiro Civil",
                "Engenheiro Eletricista",
                "Engenheiro Mecânico",
                "Engenheiro Químico",
                "Engenheiro do Petróleo",
                "Gerente",
                "Maqueiro",
                "Mecânico",
                "Militar",
                "Motorista",
                "Médico",
                "Músico",
                "Neurocirurgião",
                "Oculista",
                "Padeiro",
                "Paraquedista",
                "Percursionista",
                "Pescador",
                "Pesquisador",
                "Piloto de Aviação",
                "Piloto de F1",
                "Pintor",
                "Presidente",
                "Professor",
                "Roteirista",
                "Senador",
                "Taxista",
                "Turismólogo",
                "Técnico de Futebol",
                "Técnico em Informática",
            };
            
        }
    }
}