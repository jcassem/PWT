using Microsoft.EntityFrameworkCore;

namespace PwtDev.Models
{
    public class PwtContext : DbContext
    {
        public PwtContext(DbContextOptions<PwtContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Project> Projects { get; set; }
    }
}
