using JournalBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace JournalBackend.Data
{
    public class JournalDbContext : DbContext
    {
        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options) { }

        public DbSet<JournalEntry> JournalEntries { get; set; }
    }
}
