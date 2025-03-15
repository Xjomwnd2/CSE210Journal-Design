using Microsoft.EntityFrameworkCore;

namespace JournalBackend.Data
{
    public class JournalDbContext : DbContext
    {
        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options)
        {
        }

        // Add your DbSets here (Example)
        // public DbSet<JournalEntry> JournalEntries { get; set; }
    }
}
