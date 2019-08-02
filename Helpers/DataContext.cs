using Microsoft.EntityFrameworkCore;
using System;
using SpaBingo.Entities;

namespace SpaBingo.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Ball> Balls { get; set; }
        public DbSet<GameNumber> GameNumbers { get; set;}
        public DbSet<Row> Rows { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<BallMatch> BallMatch { get; set; }

        /* JOEL TIAGO TABLES */
        public DbSet<BingoGameConfiguration> BingoGameConfigurations { get; set; }
        public DbSet<BingoGame> BingoGames { get; set; }
        public DbSet<BingoWinPattern> BingoWinPatterns { get; set; }
        public DbSet<BingoCard> BingoCards { get; set; }
        public DbSet<BingoDrawingPrize> BingoDrawingPrizes { get; set; }
        public DbSet<BingoDrawing> BingoDrawings { get; set; }
        public DbSet<BingoGameWinPattern> BingoGameWinPatterns { get; set; }
        public DbSet<BingoWinPatternBall> BingoWinPatternBalls { get; set; }
        public DbSet<BingoCardNumber> BingoCardNumbers { get; set; }
        public DbSet<BingoDrawingBall> BingoDrawingBalls { get; set; }

        /* JOEL TIAGO TABLES */


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