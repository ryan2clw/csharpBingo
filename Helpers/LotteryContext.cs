using Microsoft.EntityFrameworkCore;
using SpaBingo.Entities.Lottery;

namespace SpaBingo.Helpers
{
    public class LotteryContext : DbContext
    {
        public LotteryContext(DbContextOptions<LotteryContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
    }
}
