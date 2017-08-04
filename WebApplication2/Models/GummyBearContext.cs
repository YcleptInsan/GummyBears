using Microsoft.EntityFrameworkCore; 

namespace GummyBear.Models
{
    public class GummyBearContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBear;integrated security=True");
        }
    }
}
