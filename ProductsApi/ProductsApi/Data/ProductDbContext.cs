using Microsoft.EntityFrameworkCore;

namespace ProductsApi.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
               .HasData(
                 new Product()
                 {
                     Id = 1,
                     Name = "Dumbell",
                     Description = "Lifting purposses"
                 },
                 new Product()
                 {
                     Id = 2,
                     Name = "Beyblade",
                     Description = "A toy"
                 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
