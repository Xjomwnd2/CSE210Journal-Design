using Microsoft.EntityFrameworkCore;

namespace JournalBackend.Data
{
    public class JournalDbContext : DbContext
    {
        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options)
        {
        }

        public DbSet<YourEntity> YourEntities { get; set; } // Replace with actual DbSet properties
    }
}
