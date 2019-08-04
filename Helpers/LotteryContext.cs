using Microsoft.EntityFrameworkCore;
using SpaBingo.Entities;

namespace SpaBingo.Helpers
{
    public class LotteryContext : DbContext
    {
        public LotteryContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
	}
}
