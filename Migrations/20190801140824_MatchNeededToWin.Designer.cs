﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaBingo.Helpers;

namespace SpaBingo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190801140824_MatchNeededToWin")]
    partial class MatchNeededToWin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BallMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BallId");

                    b.Property<int>("MatchId");

                    b.HasKey("Id");

                    b.HasIndex("BallId");

                    b.HasIndex("MatchId");

                    b.ToTable("BallMatch");
                });

            modelBuilder.Entity("SpaBingo.Entities.Ball", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumValue");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Balls");
                });

            modelBuilder.Entity("SpaBingo.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("SpaBingo.Entities.GameNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumValue");

                    b.HasKey("Id");

                    b.ToTable("GameNumbers");
                });

            modelBuilder.Entity("SpaBingo.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("B");

                    b.Property<int>("CardID");

                    b.Property<string>("G");

                    b.Property<string>("I");

                    b.Property<int>("Left");

                    b.Property<string>("N");

                    b.Property<int>("NeededToWin");

                    b.Property<string>("O");

                    b.HasKey("Id");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("SpaBingo.Entities.Row", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("B");

                    b.Property<int>("CardID");

                    b.Property<string>("G");

                    b.Property<string>("I");

                    b.Property<string>("N");

                    b.Property<string>("O");

                    b.HasKey("Id");

                    b.HasIndex("CardID");

                    b.ToTable("Rows");
                });

            modelBuilder.Entity("BallMatch", b =>
                {
                    b.HasOne("SpaBingo.Entities.Ball", "Ball")
                        .WithMany("BallMatch")
                        .HasForeignKey("BallId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpaBingo.Entities.Match", "Match")
                        .WithMany("BallMatch")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpaBingo.Entities.Row", b =>
                {
                    b.HasOne("SpaBingo.Entities.Card")
                        .WithMany("Rows")
                        .HasForeignKey("CardID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
