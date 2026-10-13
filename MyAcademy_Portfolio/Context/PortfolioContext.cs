using Microsoft.EntityFrameworkCore;
using MyAcademy_PortfolioProject.Entities;

namespace MyAcademy_PortfolioProject.Context
{
    public class PortfolioContext: DbContext
    {
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<HeroTitle> HeroTitles { get; set; }    
        public DbSet<Message> Messages { get; set; }
    }
}
