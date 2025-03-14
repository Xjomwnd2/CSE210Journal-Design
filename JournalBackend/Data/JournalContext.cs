using JournalBackend.Models;
using Microsoft.EntityFrameworkCore;// Adjust the namespace based on your project structure

namespace JournalBackend.Data
{
    public class JournalContext : DbContext
    {
        public JournalContext(DbContextOptions<JournalContext> options)
            : base(options)
        {
        }

        public DbSet<JournalEntry> JournalEntries { get; set; }
    }
}
