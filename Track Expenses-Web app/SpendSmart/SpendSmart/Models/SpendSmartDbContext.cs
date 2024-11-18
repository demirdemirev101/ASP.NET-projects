using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public SpendSmartDbContext(DbContextOptions options) : base(options) 
        {
                
        }

    }
}
