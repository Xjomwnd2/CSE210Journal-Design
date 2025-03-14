using Microsoft.EntityFrameworkCore;
using JournalBackend.Models;

namespace JournalBackend.Data
{
    public class JournalDbContext : DbContext
    {
        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options) { }

        public DbSet<JournalEntry> JournalEntries { get; set; }
    }
}
