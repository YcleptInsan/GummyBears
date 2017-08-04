using Microsoft.EntityFrameworkCore;

namespace GummyBear.Models
{
    public class GummyBearDbContext : DbContext
    {
        public GummyBearDbContext()
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBear;integrated security=True");
        }

        public GummyBearDbContext(DbContextOptions<GummyBearDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
