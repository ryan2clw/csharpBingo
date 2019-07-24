using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Entities;


namespace WebApi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<BingoNumber> BingoNumbers { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}