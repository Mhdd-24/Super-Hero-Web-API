using Microsoft.EntityFrameworkCore;
using SuperHeroWebAPI.Entities;

namespace SuperHeroWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}