using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Entities;


namespace WebApi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Ball> Balls { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<BallMatch> BallMatch { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ball>()
                .HasMany(m => m.BallMatch)
                .WithOne(m => m.Ball)
                .HasForeignKey(k => k.BallId);
            modelBuilder.Entity<Match>()
                .HasMany(r => r.BallMatch)
                .WithOne(m => m.Match)
                .HasForeignKey(k => k.MatchId);
            modelBuilder.Entity<BallMatch>()
                .HasOne(m => m.Match)
                .WithMany(m => m.BallMatch)
                .HasForeignKey(k => k.MatchId);
            modelBuilder.Entity<BallMatch>()
                .HasOne(m => m.Ball)
                .WithMany(m => m.BallMatch)
                .HasForeignKey(k => k.BallId);   
        }
    }
}