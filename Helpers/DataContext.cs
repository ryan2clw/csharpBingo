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
        public DbSet<Ball> CalledBalls { get; set; }
        public DbSet<BallMatch> BallMatches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ball>().HasMany(m => m.BallMatches).WithOne(m => m.Ball).HasForeignKey(k => k.BallId);
            modelBuilder.Entity<Row>().HasMany(r => r.BallMatches).WithOne(m => m.Row).HasForeignKey(k => k.RowId);
            modelBuilder.Entity<BallMatch>().HasOne(m => m.Row).WithMany(m => m.BallMatches).HasForeignKey(k => k.RowId);
            modelBuilder.Entity<BallMatch>().HasOne(m => m.Ball).WithMany(m => m.BallMatches).HasForeignKey(k => k.BallId);        
        }
    }
}