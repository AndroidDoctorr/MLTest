using Microsoft.EntityFrameworkCore;

namespace MLTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TextSample> TextSamples { get; set; }
    }
}