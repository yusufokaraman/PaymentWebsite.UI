using Microsoft.EntityFrameworkCore;
using PaymentWebsite.Entity.Concrete;

namespace PaymentWebsite.Data.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\Karaman; database=PaymentDb; integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
