using Microsoft.EntityFrameworkCore;

namespace Jurassic_Store.Models
{
    public class DinoDbContext : DbContext
    {
        public DinoDbContext(DbContextOptions<DinoDbContext> options) : base(options)
        {

        }

        public DbSet<Dino> dinosaurs { get; set; }

    }
}